using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            var inputText = input.Text;
            output.Text += inputText;
        }
    }
}
