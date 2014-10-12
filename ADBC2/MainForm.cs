using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using System.IO;
using ADBC2.Structures;
using DBFilesClient.NET;
using BrightIdeasSoftware;

namespace ADBC2
{
    public partial class MainForm : Form
    {
        string PathToFiles;
        Type SelectedFileType;
        
        bool OverrideCoreDefinitions { get { return xMLOverridesToolStripMenuItem.Checked; } }
        
        Dictionary<string, object> _structures = new Dictionary<string, object>();
        
        public MainForm()
        {
            InitializeComponent();
        }

        protected string GenerateSqlHeader()
        {
            var fields = SelectedFileType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
                .ToArray();

            var output = new List<string>();
            foreach (var field in fields)
            {
                var fieldType = field.FieldType.ToString();
                var arraySize = 1;
                if (field.GetCustomAttribute(typeof(StoragePresenceAttribute)) != null)
                {
                    arraySize = (Attribute.GetCustomAttribute(field, typeof(StoragePresenceAttribute)) as StoragePresenceAttribute).ArraySize;
                    fieldType = field.FieldType.GetElementType().ToString();
                }

                for (var i = 0; i < arraySize; ++i)
                {
                    var fmtString = @"  `{0}";
                    if (i > 0) fmtString += @"_{2}";
                    fmtString += @"` {1},";
                    switch (fieldType)
                    {
                        case "System.Byte":
                            output.Add(String.Format(fmtString, field.Name, "TINYINT", i));
                            break;
                        case "System.UInt16":
                        case "System.Int16":
                            output.Add(String.Format(fmtString, field.Name, "SMALLINT", i));
                            break;
                        case "System.UInt32":
                        case "System.Int32":
                            output.Add(String.Format(fmtString, field.Name, "INT", i));
                            break;
                        case "System.UInt64":
                        case "System.Int64":
                            output.Add(String.Format(fmtString, field.Name, "BIGINT", i));
                            break;
                        case "System.Single":
                            output.Add(String.Format(fmtString, field.Name, "FLOAT", i));
                            break;
                        case "System.String":
                            output.Add(String.Format(fmtString, field.Name, "TEXT", i));
                            break;
                        default:
                            StatusLabel.Text = String.Format("Error while exporting: Unknown type {0}.", fieldType.ToString());
                            return String.Empty;
                    }
                }
            }

            output[output.Count - 1] = output[output.Count - 1].TrimEnd(new[] { ',' });
            return String.Join(Environment.NewLine, output.ToArray());
        }

        #region Exporters
        /// <summary>
        /// Exports content to SQL file.
        /// </summary>
        void ToSQL(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "SQL File|*.sql";
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            File.Delete(sfd.FileName);
            using (var fileStream = new StreamWriter(sfd.OpenFile()))
            {
                var recordCount = 0;
                fileStream.WriteLine(String.Join(Environment.NewLine, new string[] {
                    @"DROP TABLE IF EXISTS `DBC_" + FileSelectionBox.Text + @"`;",
                    @"CREATE TABLE `DBC_" + FileSelectionBox.Text + @"` (",
                    GenerateSqlHeader(),
                    @");",
                    ""
                }));
                var fields = SelectedFileType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
                    .ToArray();
                var recordLine = new List<string>();
                foreach (var record in ContentView.Objects)
                {
                    if (recordCount % 500 == 0)
                        fileStream.WriteLine("INSERT INTO `DBC_" + FileSelectionBox.Text + @"` VALUES");

                    recordLine.Clear();
                    foreach (var field in fields)
                    {
                        var arraySize = 1;
                        var fieldType = field.FieldType;
                        if (field.FieldType.IsArray)
                        {
                            arraySize = (Attribute.GetCustomAttribute(field, typeof(StoragePresenceAttribute)) as StoragePresenceAttribute).ArraySize;
                            fieldType = field.FieldType.GetElementType();
                        }

                        dynamic fValue = field.GetValue(record); // Just so we do not use another variable name (my lazy ass won)
                        if (arraySize > 1)
                            fValue = ((Array)field.GetValue(record)).Cast<object>().ToArray();

                        for (var i = 0; i < arraySize; ++i)
                        {
                            var fieldFormat = (fieldType == typeof(string)) ? @"""{0}""" : @"{0}";
                            recordLine.Add(String.Format(fieldFormat, arraySize > 1 ? fValue[i] : fValue));
                        }
                    }

                    fileStream.Write(String.Format("({0})", String.Join(@", ", recordLine.ToArray())));
                    fileStream.WriteLine(((recordCount + 1) % 500 == 0 || (recordCount + 1) == ContentView.GetItemCount()) ? ";" : ",");
                    if ((recordCount + 1) % 500 == 0)
                        fileStream.WriteLine();

                    ++recordCount;
                }
            }
            StatusLabel.Text = String.Format("SQL saved to {0}.", sfd.FileName);
        }

        /// <summary>
        /// Exports DBC signature as IDA Structure to clipboard.
        /// </summary>
        void ToIDA(object sender, EventArgs e)
        {
            var fields = SelectedFileType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
                .ToArray();
            var structureText = new string[fields.Count()];
            for (var i = 0; i < fields.Length; ++i)
            {
                var fieldInfo = fields[i];
                var fieldType = fieldInfo.FieldType;
                var isArray = fieldInfo.GetCustomAttribute(typeof(StoragePresenceAttribute)) != null;
                var arrayLength = isArray
                    ? (fieldInfo.GetCustomAttribute(typeof(StoragePresenceAttribute)) as StoragePresenceAttribute).ArraySize
                    : 0;
                
                if (isArray)
                    fieldType = fieldType.GetElementType();

                var fmt = (isArray ? @"    {0} {1}[{2}];" : @"    {0} {1};") + Environment.NewLine;
                switch (fieldType.ToString())
                {
                    case "System.Byte":
                        structureText[i] = String.Format(fmt, "_BYTE", fieldInfo.Name, arrayLength);
                        break;
                    case "System.UInt16":
                    case "System.Int16":
                        structureText[i] = String.Format(fmt, "_WORD", fieldInfo.Name, arrayLength);
                        break;
                    case "System.UInt32":
                    case "System.Int32":
                        structureText[i] = String.Format(fmt, "_DWORD", fieldInfo.Name, arrayLength);
                        break;
                    case "System.UInt64":
                    case "System.Int64":
                        structureText[i] = String.Format(fmt, "_QWORD", fieldInfo.Name, arrayLength);
                        break;
                    case "System.String":
                        structureText[i] = String.Format(fmt, "char*", fieldInfo.Name, arrayLength);
                        break;
                    case "System.Single":
                        structureText[i] = String.Format(fmt, "FLOAT", fieldInfo.Name, arrayLength);
                        break;
                    default:
                        StatusLabel.Text = String.Format("Error while exporting: Unknown type {0}.", fieldType.ToString());
                        return;
                }
            }
            StatusLabel.Text = @"Structure saved to clipboard";
            Clipboard.SetText(String.Join(Environment.NewLine, structureText));
        }
        #endregion
        
        void OnBuildSelection(object sender, ToolStripItemClickedEventArgs ea)
        {
            try {
                var clientBuild = Convert.ToUInt32(ea.ClickedItem.Tag);
                _structures.Clear();
                
                // Load XML Structures
                XmlDefinitionReader.Load("./structures.xml", clientBuild);

                // Look for dbc files
                PathToFiles = String.Format(@"dbc/{0}/", clientBuild);
                var dbcNames = FindFiles(PathToFiles);

                if (dbcNames == null || dbcNames.Length == 0)
                    throw new DbcNotFoundException();
    
                dbcNames = dbcNames.OrderBy(d => d).ToArray();
                var structures = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => {
                               var attr = Attribute.GetCustomAttribute(t, typeof(DbFileInfoAttribute), false) as DbFileInfoAttribute;
                               return t.IsClass && t.IsSealed && attr != null && attr.Build == clientBuild && attr.Enabled;
                           }).ToArray();

                var xmlStructures = XmlDefinitionReader.GetStructures();
                
                if (structures.Length == 0)
                    throw new UnsupportedClientBuildException(clientBuild);
                
                var items = new string[structures.Length];
                var coreStructuresCount = 0;
                for (var i = 0; i < structures.Length; ++i)
                {
                    var attr = structures[i].GetCustomAttributes(typeof(DbFileInfoAttribute), false).First() as DbFileInfoAttribute;
                    if (attr == null || !dbcNames.Contains(attr.FileName))
                        throw new DbcFileNameNotFoundException(attr.FileName);

                    items[i] = attr.FileName;
                    _structures.Add(items[i], structures[i]);
                    ++coreStructuresCount;
                }
                
                // Overwrite with XML structures
                for (var i = 0; i < xmlStructures.Count; ++i)
                {
                    if (_structures.ContainsKey(xmlStructures.Keys.ElementAt(i)))
                    {
                        if (OverrideCoreDefinitions)
                        {
                            _structures[xmlStructures.Keys.ElementAt(i)] = xmlStructures.Values.ElementAt(i);
                            --coreStructuresCount;
                        }
                    }
                    else
                    {
                        _structures.Add(xmlStructures.Keys.ElementAt(i), xmlStructures.Values.ElementAt(i));
                        --coreStructuresCount;
                    }
                }

                FileSelectionBox.Enabled = true;
                FileSelectionBox.Items.Clear();
                FileSelectionBox.Items.AddRange(items);
                StatusLabel.Text = String.Format(@"Version: {2}. {0} Core Definition(s) loaded. {1} XML Definition(s) loaded.", coreStructuresCount, items.Length - coreStructuresCount, clientBuild);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                FileSelectionBox.Enabled = false;
                SqlExport.Enabled = false;
                IdaExport.Enabled = false;
                StatusLabel.Text = dnfe.Message;
            }
            catch (UnsupportedClientBuildException ucbe)
            {
                FileSelectionBox.Enabled = false;
                SqlExport.Enabled = false;
                IdaExport.Enabled = false;
                StatusLabel.Text = ucbe.Message;
            }
            catch (DbcNotFoundException)
            {
                FileSelectionBox.Enabled = false;
                SqlExport.Enabled = false;
                IdaExport.Enabled = false;
                StatusLabel.Text = @"No DBC file found in the provided path.";                
            }
        }
        
        /// <summary>
        /// Parses the selected file
        /// </summary>
        void OnFileSelection(object unboxSender, EventArgs e)
        {
            var sender = unboxSender as ComboBox;
            if (sender == null)
                return;

            var watch = new Stopwatch();
            watch.Start();
            
            SelectedFileType = _structures[(string)sender.Items[sender.SelectedIndex]] as Type;
            
            var storageType = typeof(DBCStorage<>);
            if (Path.GetExtension(sender.Text) == @".db2")
                storageType = typeof(DB2Storage<>);

            storageType = storageType.MakeGenericType(SelectedFileType);
            var store = Activator.CreateInstance(storageType);

            using (var strm = new FileStream(String.Format(PathToFiles + "{0}", sender.Text), FileMode.Open))
                storageType.GetMethod("Load", new [] { typeof(FileStream) }).Invoke(store, new[] { (object)strm });
            
            dynamic records = storageType.GetProperty("Records").GetValue(store);

            PropertyInfo[] props = SelectedFileType.GetProperties(); 
            Generator.GenerateColumns(ContentView, SelectedFileType, false);
            ContentView.SetObjects(records, false);
            watch.Stop();
            StatusLabel.Text = String.Format("Loaded {0} records in {1} ms.", records.Count, watch.ElapsedMilliseconds);
            SqlExport.Enabled = true;
            IdaExport.Enabled = true;
        }

        void OnCellEditStart(object sender, CellEditEventArgs e)
        {
            // e.Cancel = true;
            // NYI (Hitting F2 on a cell = copy cell value)
        }

        void ShowHelp(object sender, EventArgs e)
        {
            var form = new HelpForm();
            form.Show();
        }

        void OnTooltipShow(object sender, ToolTipShowingEventArgs e)
        {
            var item = ContentView.GetItem(e.RowIndex);
            if (item == null)
                return;

            var rowObject = item.RowObject;
            if (rowObject == null)
                return;
                
            var columnHeader = ContentView.GetColumn(e.ColumnIndex);
            if (columnHeader == null)
                return;

            var cellInfo = rowObject.GetType().GetField(columnHeader.AspectName);
            if (cellInfo == null)
                throw new Exception(String.Format(@"Unexpected exception that should not happen: Type {0} does not contain a field named {1}.", rowObject.GetType(), columnHeader.AspectName));
            
            if (cellInfo.FieldType == typeof(string))
                e.Text = cellInfo.GetValue(rowObject) as string;
            else if (cellInfo.GetCustomAttribute(typeof(StoragePresenceAttribute), false) != null)
            {
                var items = ((Array)cellInfo.GetValue(rowObject)).Cast<object>().ToArray();
                e.Text = @"[ " + String.Join(", ", items) + @" ]";
            }
        }

        void OnDoubleClick(object sender, EventArgs e)
        {
            // TODO: Can only single-click the first cell.
            ContentView.FullRowSelect = !ContentView.FullRowSelect;
            ContentView.RedrawItems(ContentView.HotRowIndex, ContentView.HotRowIndex, true);
        }

        void OpenSearchForm(object sender, EventArgs e)
        {
            
        }

        void OpenStructConverter(object sender, EventArgs e)
        {
            var form = new StructConvertionForm();
            form.Show();
        }

        string[] FindFiles(string path)
        {
            try
            {
                var dbcNames = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => s.EndsWith(".dbc", StringComparison.CurrentCultureIgnoreCase) || s.EndsWith(".db2", StringComparison.CurrentCultureIgnoreCase))
                    .Select(Path.GetFileName).ToArray();

                if (dbcNames.Count() == 0)
                    throw new DirectoryNotFoundException();
                return dbcNames;
            }
            catch (DirectoryNotFoundException)
            {
                var ofd = new FolderBrowserDialog();
                ofd.Description = "Indicate the path to your *.dbc and *.db2 files";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PathToFiles = ofd.SelectedPath;
                    return FindFiles(ofd.SelectedPath);
                }
            }
            return null;
        }
        
        void OnXmlOverridesToggle(object sender, EventArgs e)
        {
            xMLOverridesToolStripMenuItem.Checked = !xMLOverridesToolStripMenuItem.Checked;
        }
    }
}
