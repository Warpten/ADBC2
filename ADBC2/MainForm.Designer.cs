/*
 * Created by SharpDevelop.
 * User: Warpten
 * Date: 15/09/2014
 * Time: 19:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ADBC2
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SqlExport = new System.Windows.Forms.ToolStripMenuItem();
            this.IdaExport = new System.Windows.Forms.ToolStripMenuItem();
            this.StructConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLOverridesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContentView = new BrightIdeasSoftware.FastObjectListView();
            this.FileSelectionBox = new System.Windows.Forms.ComboBox();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.clientVersionToolStripMenuItem,
                                    this.toolsToolStripMenuItem,
                                    this.settingsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientVersionToolStripMenuItem
            // 
            this.clientVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.toolStripMenuItem2,
                                    this.toolStripMenuItem3,
                                    this.toolStripMenuItem4});
            this.clientVersionToolStripMenuItem.Name = "clientVersionToolStripMenuItem";
            this.clientVersionToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.clientVersionToolStripMenuItem.Tag = "";
            this.clientVersionToolStripMenuItem.Text = "Client version";
            this.clientVersionToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnBuildSelection);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Tag = "12340";
            this.toolStripMenuItem2.Text = "3.3.5.12340";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Tag = "15595";
            this.toolStripMenuItem3.Text = "4.3.4.15595";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.SqlExport,
                                    this.IdaExport,
                                    this.StructConverter});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // SqlExport
            // 
            this.SqlExport.Enabled = false;
            this.SqlExport.Name = "SqlExport";
            this.SqlExport.Size = new System.Drawing.Size(193, 22);
            this.SqlExport.Text = "Export content as SQL";
            this.SqlExport.Click += new System.EventHandler(this.ToSQL);
            // 
            // IdaExport
            // 
            this.IdaExport.Enabled = false;
            this.IdaExport.Name = "IdaExport";
            this.IdaExport.Size = new System.Drawing.Size(193, 22);
            this.IdaExport.Text = "Export structure to IDA";
            this.IdaExport.Click += new System.EventHandler(this.ToIDA);
            // 
            // StructConverter
            // 
            this.StructConverter.Name = "StructConverter";
            this.StructConverter.Size = new System.Drawing.Size(193, 22);
            this.StructConverter.Text = "Convert structures...";
            this.StructConverter.Click += new System.EventHandler(this.OpenStructConverter);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.xMLOverridesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // xMLOverridesToolStripMenuItem
            // 
            this.xMLOverridesToolStripMenuItem.Name = "xMLOverridesToolStripMenuItem";
            this.xMLOverridesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.xMLOverridesToolStripMenuItem.Text = "XML Overrides";
            this.xMLOverridesToolStripMenuItem.ToolTipText = "XML Structures will override built-in types.";
            this.xMLOverridesToolStripMenuItem.Click += new System.EventHandler(this.OnXmlOverridesToggle);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.ShowHelp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(913, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ContentView
            // 
            this.ContentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.F2Only;
            this.ContentView.FullRowSelect = true;
            this.ContentView.GridLines = true;
            this.ContentView.HeaderUsesThemes = false;
            this.ContentView.HeaderWordWrap = true;
            this.ContentView.IncludeColumnHeadersInCopy = true;
            this.ContentView.Location = new System.Drawing.Point(0, 28);
            this.ContentView.Name = "ContentView";
            this.ContentView.ShowCommandMenuOnRightClick = true;
            this.ContentView.ShowGroups = false;
            this.ContentView.Size = new System.Drawing.Size(913, 314);
            this.ContentView.TabIndex = 3;
            this.ContentView.UseCompatibleStateImageBehavior = false;
            this.ContentView.UseFilterIndicator = true;
            this.ContentView.UseFiltering = true;
            this.ContentView.View = System.Windows.Forms.View.Details;
            this.ContentView.VirtualMode = true;
            this.ContentView.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.OnCellEditStart);
            this.ContentView.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.OnTooltipShow);
            this.ContentView.DoubleClick += new System.EventHandler(this.OnDoubleClick);
            // 
            // FileSelectionBox
            // 
            this.FileSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileSelectionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FileSelectionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FileSelectionBox.Enabled = false;
            this.FileSelectionBox.FormattingEnabled = true;
            this.FileSelectionBox.Location = new System.Drawing.Point(716, 3);
            this.FileSelectionBox.MaxDropDownItems = 20;
            this.FileSelectionBox.Name = "FileSelectionBox";
            this.FileSelectionBox.Size = new System.Drawing.Size(185, 21);
            this.FileSelectionBox.TabIndex = 4;
            this.FileSelectionBox.SelectedIndexChanged += new System.EventHandler(this.OnFileSelection);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Tag = "18179";
            this.toolStripMenuItem4.Text = "6.0.1.18179";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 367);
            this.Controls.Add(this.FileSelectionBox);
            this.Controls.Add(this.ContentView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ADBC2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientVersionToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem IdaExport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private BrightIdeasSoftware.FastObjectListView ContentView;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLOverridesToolStripMenuItem;
        private System.Windows.Forms.ComboBox FileSelectionBox;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SqlExport;
        private System.Windows.Forms.ToolStripMenuItem StructConverter;
    }
}
