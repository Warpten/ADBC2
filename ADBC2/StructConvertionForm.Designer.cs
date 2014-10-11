
namespace ADBC2
{
    partial class StructConvertionForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button csToXmlButton;
        private System.Windows.Forms.Button xmlToCsButton;
        private System.Windows.Forms.RichTextBox csRtb;
        private System.Windows.Forms.RichTextBox xmlRtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        
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
            this.csToXmlButton = new System.Windows.Forms.Button();
            this.xmlToCsButton = new System.Windows.Forms.Button();
            this.csRtb = new System.Windows.Forms.RichTextBox();
            this.xmlRtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // csToXmlButton
            // 
            this.csToXmlButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.csToXmlButton.Location = new System.Drawing.Point(13, 37);
            this.csToXmlButton.Name = "csToXmlButton";
            this.csToXmlButton.Size = new System.Drawing.Size(75, 25);
            this.csToXmlButton.TabIndex = 0;
            this.csToXmlButton.UseVisualStyleBackColor = true;
            this.csToXmlButton.Click += new System.EventHandler(this.ToXML);
            // 
            // xmlToCsButton
            // 
            this.xmlToCsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xmlToCsButton.Location = new System.Drawing.Point(13, 3);
            this.xmlToCsButton.Name = "xmlToCsButton";
            this.xmlToCsButton.Size = new System.Drawing.Size(75, 25);
            this.xmlToCsButton.TabIndex = 1;
            this.xmlToCsButton.UseVisualStyleBackColor = true;
            this.xmlToCsButton.Click += new System.EventHandler(this.ToCSharp);
            // 
            // csRtb
            // 
            this.csRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.csRtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.csRtb.Location = new System.Drawing.Point(3, 33);
            this.csRtb.Name = "csRtb";
            this.csRtb.Size = new System.Drawing.Size(261, 269);
            this.csRtb.TabIndex = 2;
            this.csRtb.Text = "";
            // 
            // xmlRtb
            // 
            this.xmlRtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlRtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xmlRtb.Location = new System.Drawing.Point(377, 33);
            this.xmlRtb.Name = "xmlRtb";
            this.xmlRtb.Size = new System.Drawing.Size(262, 269);
            this.xmlRtb.TabIndex = 3;
            this.xmlRtb.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "C# Structures";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(377, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "XML Structures";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.Location = new System.Drawing.Point(3, 309);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 28);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Export C# as old style XML";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                    | System.Windows.Forms.AnchorStyles.Left) 
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.Controls.Add(this.csRtb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.xmlRtb, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 340);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.csToXmlButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.xmlToCsButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(270, 133);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(101, 69);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // StructConvertionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 365);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(683, 401);
            this.Name = "StructConvertionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Struct Converter";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
