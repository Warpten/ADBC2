using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
        private string filesPath;
        
        public Dictionary<string, object> _structures = new Dictionary<string, object>();
        
        public MainForm()
        {
            InitializeComponent();
        }
        
        #region Exporters
        /// <summary>
        /// Exports content to SQL file.
        /// </summary>
        void ToSQL(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        /// Exports DBC signature as IDA Structure to clipboard.
        /// </summary>
        void ToIDA(object sender, EventArgs e)
        {
            
        }
        #endregion
        
        void OnBuildSelection(object sender, EventArgs ea)
        {
            try {
                var clientBuild = Convert.ToUInt32((sender as ToolStripMenuItem).Tag);
                // Populate dropdown menus
                var unhandledCount = 0;
                
                filesPath = String.Format(@"dbc/{0}/", clientBuild);
                string[] dbcNames = Directory.EnumerateFiles(filesPath, "*.*", SearchOption.TopDirectoryOnly)
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
                loadFileToolStripMenuItem.DropDownItems.AddRange(items);
                loadFileToolStripMenuItem.Enabled = true;
                
                StatusLabel.Text = unhandledCount == 0 ? string.Empty : String.Format("{0} unhandled DBC files.", unhandledCount);
                
            }
            catch (UnsupportedClientBuildException ucbe)
            {
                loadFileToolStripMenuItem.DropDownItems.Clear();
                loadFileToolStripMenuItem.Enabled = false;
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
            
            var structure = _structures[sender.Text] as Type;
            
            var storageType = typeof(DBCStorage<>);
            if (Path.GetExtension(sender.Text) == @".db2")
                storageType = typeof(DB2Storage<>);
            
            storageType = storageType.MakeGenericType(new Type[] { structure });
            var store = Activator.CreateInstance(storageType);
            using (var strm = new FileStream(String.Format(filesPath + "{0}", sender.Text), FileMode.Open))
                storageType.GetMethod("Load", new Type[] { typeof(FileStream) }).Invoke(store, new[] { (object)strm });
            
            dynamic _records = Activator.CreateInstance(typeof(List<>).MakeGenericType(structure));
            using (dynamic dbcRecords = storageType.GetProperty("Records").GetValue(store))
                foreach (var record in dbcRecords)
                    _records.Add(record);

            PropertyInfo[] props = structure.GetProperties();
            // Library code has been modified to allow using fields - not working yet, though
            // Legacy call: Generator.GenerateColumns(this.ContentListView, structure, true); 
            Generator.GenerateColumns(this.ContentListView, structure, true);
            ContentListView.SetObjects(_records, false);
            watch.Stop();
            StatusLabel.Text = String.Format("Loaded {0} records in {1} ms.", _records.Count, watch.ElapsedMilliseconds);
        }
    }
}
