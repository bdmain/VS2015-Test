using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT_Test_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "CAPS")
            {

                textBox1.Text = (textBox1.Text).ToUpper();
                button1.Text = "LOWER";
            }
            else
            {
                textBox1.Text = (textBox1.Text).ToLower();
                button1.Text = "CAPS";
            }
        }
    }
}
