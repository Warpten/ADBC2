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
        public string SelectedBuild;
        public string SelectedFile;
        string FilesPath;
        Type FileStructure;
        
        public Dictionary<string, object> _structures = new Dictionary<string, object>();
        
        public MainForm()
        {
            InitializeComponent();
            // ContentListView.HotItemStyle = this.hotItemStyle1;
        }
        
        #region Exporters
        /// <summary>
        /// Exports content to SQL file.
        /// </summary>
        void ToSQL(object sender, EventArgs e)
        {
            // var items = ContentListView.Items;
            // Console.Write("foo");
        }
        
        /// <summary>
        /// Exports DBC signature as IDA Structure to clipboard.
        /// </summary>
        void ToIDA(object sender, EventArgs e)
        {
            var fields = FileStructure.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
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
                var idaType = string.Empty;
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
        
        void OnBuildSelection(object sender, EventArgs ea)
        {
            try {
                var clientBuild = Convert.ToUInt32((sender as ToolStripMenuItem).Tag);
                // Populate dropdown menus
                var unhandledCount = 0;
                
                FilesPath = String.Format(@"dbc/{0}/", clientBuild);
                string[] dbcNames = Directory.EnumerateFiles(FilesPath, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => s.EndsWith(".dbc", StringComparison.CurrentCultureIgnoreCase) || s.EndsWith(".db2", StringComparison.CurrentCultureIgnoreCase))
                    .Select(Path.GetFileName).ToArray();
                if (dbcNames.Length == 0)
                    throw new DbcNotFoundException();
    
                dbcNames = dbcNames.OrderBy(d => d).ToArray();
                var structures = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.IsClass && t.IsSealed && t.GetCustomAttributes(typeof(ClientVersionAttribute), false).Length == 1 && (t.GetCustomAttributes(typeof(ClientVersionAttribute), false).First() as ClientVersionAttribute).Build == clientBuild && t.GetCustomAttributes(typeof(FileStructureAttribute), false).Length == 1)
                    .ToArray();
                
                if (structures.Length == 0)
                    throw new UnsupportedClientBuildException(clientBuild);
                
                var items = new ToolStripMenuItem[structures.Length];
    
                for (var i = 0; i < structures.Length; ++i)
                {
                    var attr = structures[i].GetCustomAttributes(typeof(FileStructureAttribute), false).First() as FileStructureAttribute;
                    if (attr == null || !dbcNames.Contains(attr.FileName))
                    {
                        ++unhandledCount;
                        continue;
                    }
                    
                    items[i] = new ToolStripMenuItem(dbcNames.First(t => t == attr.FileName));
                    _structures.Add(items[i].Text, structures[i]);
                }
                LoadFile.DropDownItems.AddRange(items);
                LoadFile.Enabled = true;
                
                StatusLabel.Text = unhandledCount == 0 ? string.Empty : String.Format("{0} unhandled DBC files.", unhandledCount);
                
            }
            catch (DirectoryNotFoundException dnfe)
            {
                LoadFile.DropDownItems.Clear();
                LoadFile.Enabled = false;
                SqlExport.Enabled = false;
                IdaExport.Enabled = false;
                StatusLabel.Text = dnfe.ToString();
            }
            catch (UnsupportedClientBuildException ucbe)
            {
                LoadFile.DropDownItems.Clear();
                LoadFile.Enabled = false;
                SqlExport.Enabled = false;
                IdaExport.Enabled = false;
                StatusLabel.Text = ucbe.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        /// <summary>
        /// Parses the selected file
        /// </summary>
        void OnFileSelected(object so, ToolStripItemClickedEventArgs e)
        {
            var sender = (e.ClickedItem as ToolStripMenuItem);
            if (sender == null)
                return;

            var watch = new Stopwatch();
            watch.Start();
            
            FileStructure = _structures[sender.Text] as Type;
            
            var storageType = typeof(DBCStorage<>);
            if (Path.GetExtension(sender.Text) == @".db2")
                storageType = typeof(DB2Storage<>);
            
            storageType = storageType.MakeGenericType(new Type[] { FileStructure });
            var store = Activator.CreateInstance(storageType);
            using (var strm = new FileStream(String.Format(FilesPath + "{0}", sender.Text), FileMode.Open))
                storageType.GetMethod("Load", new Type[] { typeof(FileStream) }).Invoke(store, new[] { (object)strm });
            
            dynamic records = storageType.GetProperty("Records").GetValue(store);

            PropertyInfo[] props = FileStructure.GetProperties(); 
            Generator.GenerateColumns(this.ContentListView, FileStructure, false);
            ContentListView.SetObjects(records, false);
            watch.Stop();
            StatusLabel.Text = String.Format("Loaded {0} records in {1} ms.", records.Count, watch.ElapsedMilliseconds);
            SqlExport.Enabled = true;
            IdaExport.Enabled = true;
        }

        void OnCellEditStart(object sender, CellEditEventArgs e)
        {
            e.Cancel = true;
            // NYI (Hitting F2 on a cell = copy cell value)
        }

        void ShowHelp(object sender, EventArgs e)
        {
            var form = new HelpForm();
            form.Show();
        }

        void OnTooltipShow(object sender, ToolTipShowingEventArgs e)
        {
            var item = ContentListView.GetItem(e.RowIndex);
            if (item == null)
                return;

            var rowObject = item.RowObject;
            if (rowObject == null)
                return;
                
            var columnHeader = ContentListView.GetColumn(e.ColumnIndex);
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
            // ContentListView.FullRowSelect = true;
        }

        void OnSingleClick(object sender, EventArgs e)
        {
            // ContentListView.FullRowSelect = false;
        }
    }
}
