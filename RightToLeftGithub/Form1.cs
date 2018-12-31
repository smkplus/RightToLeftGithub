using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightToLeftGithub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TypeBox.SelectedIndex = 0;
            Input.Text = "WriteHere";
            Output.Text = "ConvertedText";


        }

        private void Convert_Click(object sender, EventArgs e)
        {
            string pattern = @"(.+)";
            string substitution = "";
            var Type = TypeBox.SelectedItem.ToString();
            if (Type == "Normal")
            {
                substitution = @"<div dir=""rtl""> $0 </div> ";
            }
            else if (Type == "Bold")
            {
                substitution = @"<div dir=""rtl""> <b> $0 </b> </div> ";
            }
            else if (Type == "Italic")
            {
                substitution = @"<div dir=""rtl""> <i> $0 </i> </div> ";
            }
            else if (Type == "H1")
            {
                substitution = @"<div dir=""rtl""> <h1> $0 </h1> </div> ";
            }
            else if (Type == "H2")
            {
                substitution = @"<div dir=""rtl""> <h2> $0 </h2> </div> ";
            }
            else if (Type == "H3")
            {
                substitution = @"<div dir=""rtl""> <h3> $0 </h3> </div> ";
            }
            else if (Type == "H4")
            {
                substitution = @"<div dir=""rtl""> <h4> $0 </h4> </div> ";
            }
            else if (Type == "H5")
            {
                substitution = @"<div dir=""rtl""> <h5> $0 </h5> </div> ";
            }
            if(substitution != "")
            {

            Regex regex = new Regex(pattern);
            Output.Text = regex.Replace(Input.Text, substitution);
            Clipboard.SetText(Output.Text);
            MessageBox.Show("Text Converted And Copied");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
