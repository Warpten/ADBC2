
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
            this.SuspendLayout();
            // 
            // csToXmlButton
            // 
            this.csToXmlButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.csToXmlButton.Location = new System.Drawing.Point(292, 172);
            this.csToXmlButton.Name = "csToXmlButton";
            this.csToXmlButton.Size = new System.Drawing.Size(75, 23);
            this.csToXmlButton.TabIndex = 0;
            this.csToXmlButton.UseVisualStyleBackColor = true;
            this.csToXmlButton.Click += new System.EventHandler(this.ToCSharp);
            // 
            // xmlToCsButton
            // 
            this.xmlToCsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.xmlToCsButton.Location = new System.Drawing.Point(292, 201);
            this.xmlToCsButton.Name = "xmlToCsButton";
            this.xmlToCsButton.Size = new System.Drawing.Size(75, 23);
            this.xmlToCsButton.TabIndex = 1;
            this.xmlToCsButton.UseVisualStyleBackColor = true;
            this.xmlToCsButton.Click += new System.EventHandler(this.ToXML);
            // 
            // csRtb
            // 
            this.csRtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.csRtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.csRtb.Location = new System.Drawing.Point(13, 37);
            this.csRtb.Name = "csRtb";
            this.csRtb.Size = new System.Drawing.Size(273, 282);
            this.csRtb.TabIndex = 2;
            this.csRtb.Text = "";
            // 
            // xmlRtb
            // 
            this.xmlRtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xmlRtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xmlRtb.Location = new System.Drawing.Point(373, 37);
            this.xmlRtb.Name = "xmlRtb";
            this.xmlRtb.Size = new System.Drawing.Size(273, 282);
            this.xmlRtb.TabIndex = 3;
            this.xmlRtb.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "C# Structures";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(373, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "XML Structures";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StructConvertionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xmlRtb);
            this.Controls.Add(this.csRtb);
            this.Controls.Add(this.xmlToCsButton);
            this.Controls.Add(this.csToXmlButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 367);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 367);
            this.Name = "StructConvertionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Struct Converter";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }
    }
}
