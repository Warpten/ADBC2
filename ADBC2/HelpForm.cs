using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADBC2
{
    /// <summary>
    /// Description of HelpForm.
    /// </summary>
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        void OnLoad(object sender, EventArgs e)
        {
            richTextBox1.SetBold();
            richTextBox1.AppendLine(@"Hints");
            richTextBox1.SetBold(false);
            richTextBox1.AppendLine(@"- Hovering a cell containing a string will display the complete string in a tooltip.");
            richTextBox1.AppendLine("- Hovering a cell containing the word \"Array\" will display the array's content in a tooltip.");
            richTextBox1.AppendLine("- Double-clicking a cell will start editing its content.");
            richTextBox1.AppendLine("- Hitting Ctrl+C with either a row or a cell selected will copy the cell(s) and its/their header(s) to the clipboard.");

            richTextBox1.AppendLine();
            richTextBox1.AppendLine(@"© ® Warpten 2014, for TrinityCore.");
            richTextBox1.AppendLine(@"Visit the code on https://www.github.com/Warpten/ADBC2");
        }
    }
}
