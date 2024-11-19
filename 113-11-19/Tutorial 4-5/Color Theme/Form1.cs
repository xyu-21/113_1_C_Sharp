using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            if (checkBox1.Checked) 
            {
                res += "You checked the box1.\n";
                MessageBox.Show(res);
            }
            if (checkBox2.Checked)
            {
                res += "You checked the box2.\n";
                MessageBox.Show(res);
            }
            if (checkBox3.Checked)
            {
                res += "You checked the box3.\n";
                MessageBox.Show(res);
            }
        }
    }
}
