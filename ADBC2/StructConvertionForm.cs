
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADBC2
{
    /// <summary>
    /// Description of StructConvertionForm.
    /// </summary>
    public partial class StructConvertionForm : Form
    {
        public StructConvertionForm()
        {
            InitializeComponent();
        }

		void ToXML(object sender, EventArgs e)
		{
	
		}

		void ToCSharp(object sender, EventArgs e)
		{
	
		}

		void OnLoad(object sender, EventArgs e)
		{
		    xmlToCsButton.Text = char.ConvertFromUtf32(8592);
		    csToXmlButton.Text = char.ConvertFromUtf32(8594);
		}
    }
}
