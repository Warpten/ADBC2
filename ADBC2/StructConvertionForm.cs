using System;
using System.Xml;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace ADBC2
{
    /// <summary>
    /// Description of StructConvertionForm.
    /// </summary>
    public partial class StructConvertionForm : Form
    {
        bool OldFormatXml { get { return checkBox1.Checked; } }

        static Regex _dbFileInfo = new Regex(@"\[DbFileInfo\(([0-9]+), ""(.+)""\)\]", RegexOptions.IgnoreCase);
        static Regex _fieldInfo = new Regex(@"public ([a-z]+)(\[\])? (.+);", RegexOptions.IgnoreCase);
        static Regex _arraySize = new Regex(@"\[StoragePresence\(StoragePresenceOption.(?:.+), ArraySize = ([0-9]+)\)\]", RegexOptions.IgnoreCase);

        public StructConvertionForm()
        {
            InitializeComponent();
        }

        void ToXML(object sender, EventArgs e)
        {
            var structure = csRtb.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            xmlRtb.Text = String.Empty;
            var fileName = String.Empty;
            var arraySize = 0;

            var hasBinding = false;
            var hasFields = false;

            foreach (var line in structure)
            {
                Match matchSet = null;
                if ((matchSet = _dbFileInfo.Match(line)).Success)
                {
                    hasBinding = true;
                    if (OldFormatXml)
                        xmlRtb.AppendFormatLine("<{0}{2} build={1}{2}>",
                                                fileName = Path.GetFileNameWithoutExtension(matchSet.Groups[2].Value),
                                                matchSet.Groups[1].Value,
                                                matchSet.Groups[2].Value.IndexOf(".db2") != -1 ? @" db2=""1""" : String.Empty
                                               );
                    else
                        xmlRtb.AppendFormatLine("<file name=\"{0}\" build=\"{1}\">",
                                                fileName = matchSet.Groups[2].Value,
                                                matchSet.Groups[1].Value);
                }
                else if ((matchSet = _arraySize.Match(line)).Success)
                {
                    arraySize = int.Parse(matchSet.Groups[1].Value);
                }
                else if ((matchSet = _fieldInfo.Match(line)).Success)
                {
                    hasFields = true;
                    if (arraySize > 0 && !matchSet.Groups[2].Success)
                    {
                        arraySize = 0;
                        Alert("Field {0} is defined as an array but does not have a StoragePresence attribute", matchSet.Groups[3].Value);
                    }

                    if (!OldFormatXml)
                    {
                        xmlRtb.AppendFormatLine("  <field name=\"{0}\" type=\"{1}\" {2}/>",
                                                matchSet.Groups[3].Value,
                                                matchSet.Groups[1].Value,
                                                arraySize > 0 ? ("array=\"" + arraySize + "\"") : "");
                    }
                    else if (OldFormatXml)
                    {
                        if (arraySize == 0)
                            xmlRtb.AppendFormatLine("  <field name=\"{0}\" type=\"{1}\" />",
                                                    matchSet.Groups[3].Value,
                                                    matchSet.Groups[1].Value);
                        else
                            for (var i = 0; i < arraySize; ++i)
                                xmlRtb.AppendFormatLine("  <field name=\"{0}{2}\" type=\"{1}\" />",
                                                        matchSet.Groups[3].Value,
                                                        matchSet.Groups[1].Value, i);
                    }

                    arraySize = 0;
                }
                else if (line.IndexOf("}") != -1)
                {
                    xmlRtb.AppendFormatLine(OldFormatXml ? "</{0}>" : "</file>", fileName);
                    xmlRtb.AppendLine();

                    // TODO Log errors
                    // if (!hasBinding)
                    //     ...

                    hasBinding = false;
                    hasFields  = false;
                }
            }
        }

        void ToCSharp(object sender, EventArgs e)
        {
            try {
                var document = new XmlDocument();
                document.LoadXml(xmlRtb.Text);
                xmlRtb.Text = string.Empty;
                if (document.GetElementsByTagName("DBFilesClient").Count != 0)
                    ToCSharpFromOldFormat(document);
                else
                    ToCSharpFromNewFormat(document);
            }
            catch (Exception)
            {
                // Do nothing
            }
        }

        void OnLoad(object sender, EventArgs e)
        {
            xmlToCsButton.Text = char.ConvertFromUtf32(8592);
            csToXmlButton.Text = char.ConvertFromUtf32(8594);
        }

        protected string ConvertType(string sourceType)
        {
            switch (sourceType)
            {
                case "i32": case "int32":
                    return "int";
                case "u32": case "u32":
                    return "uint";
                case "i64": case "int64":
                    return "long";
                case "u64": case "uint64":
                    return "ulong";
                case "i8": case "int8":
                    return "sbyte";
                case "u8": case "uint8":
                    return "byte";
                case "f": return "float";
            }
            return sourceType; // TODO Implement i32 etc
        }

        protected void ToCSharpFromOldFormat(XmlDocument document)
        {
            var structures = document["DBFilesClient"].ChildNodes;
            foreach (XmlNode structure in structures)
            {
                var build = structure.Attributes["build"].Value;
                var fileName = String.Format(@"{0}.{1}", structure.Name, structure.Attributes["DB2"] != null ? "db2" : "dbc");

                csRtb.AppendFormatLine("[DbFileInfo({0}, \"{1}\")]", build, fileName);
                csRtb.AppendFormatLine(@"public sealed class {0}Entry", structure.Name.Replace(@"_", @""));
                csRtb.AppendLine("{");

                foreach (XmlNode field in structure.ChildNodes)
                    if (field.Name == "field")
                        csRtb.AppendFormatLine(@"    public {0} {1};", ConvertType(field.Attributes["type"].Value), field.Attributes["name"].Value);

                csRtb.AppendLine("};");
                csRtb.AppendLine();
            }
        }

        protected void ToCSharpFromNewFormat(XmlDocument document)
        {
            if (!document["Definitions"].HasChildNodes)
                return;

            var structures = document["Definitions"].GetElementsByTagName(@"file");
            foreach (XmlNode structure in structures)
            {
                var build = structure.Attributes["build"].Value;
                var fileName = structure.Attributes["name"].Value;

                csRtb.AppendFormatLine("[DbFileInfo({0}, \"{1}\")]", build, fileName);
                csRtb.AppendFormatLine("public sealed class {0}Entry", fileName);
                csRtb.AppendLine("{");

                foreach (XmlNode field in structure)
                {
                    if (field.Name != "field")
                        continue;

                    var arraySize = 0;
                    if (field.Attributes["array"] != null)
                        arraySize = Convert.ToInt32(field.Attributes["array"].Value);

                    if (arraySize != 0)
                        csRtb.AppendFormatLine("    [StoragePresence(StoragePresenceOption.Include, ArraySize = {0})]", arraySize);

                    csRtb.AppendFormatLine("    public {0}{1} {2};", ConvertType(field.Attributes["type"].Value), arraySize != 0 ? "[]" : "", field.Attributes["name"].Value);
                }

                csRtb.AppendLine("}");
                csRtb.AppendLine();
            }
        }

        protected void Alert(string message, params object[] args)
        {
            MessageBox.Show(String.Format(message, args), "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
