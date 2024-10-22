using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENYS_VALUE = 0.05m;
        const decimal TEN_CENYS_VALUE = 0.10m;
        const decimal TWENTYFIVE_CENYS_VALUE = 0.25m;
        const decimal FIFTY_CENYS_VALUE = 0.50m;
        const decimal TOTAL = 0.00m;
        private decimal total ;
        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //total = total + 0.05m;            
            total += FIVE_CENYS_VALUE;
            totalLabel.Text = total.ToString("C");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENYS_VALUE;
            totalLabel.Text = total.ToString("C");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTYFIVE_CENYS_VALUE;
            totalLabel.Text = total.ToString("C");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENYS_VALUE;
            totalLabel.Text = total.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            total = TOTAL;
            totalLabel.Text = total.ToString("C");
        }
    }
}
