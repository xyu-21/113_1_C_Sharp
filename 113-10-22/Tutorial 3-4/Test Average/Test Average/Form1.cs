using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal test1;
            decimal test2;
            decimal test3;
            decimal average;
            try
            {
                test1 = decimal.Parse(test1TextBox.Text);
                test2 = decimal.Parse(test2TextBox.Text);
                test3 = decimal.Parse(test3TextBox.Text);
                average = (test1 + test2 + test3)/3;

                averageLabel.Text = average.ToString("n");
            }
            catch 
            {
                MessageBox.Show("輸入資料格式錯誤");
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                test1TextBox.Focus();
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
