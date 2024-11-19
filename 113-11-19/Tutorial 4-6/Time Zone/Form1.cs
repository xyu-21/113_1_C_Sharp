using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            city = cityListBox.SelectedItem.ToString();

            switch (city)
           { 

           case "Denver":
                timeZoneLabel.Text = "Mountain";
                break;
           case "Honolulu":
                timeZoneLabel.Text = "Hawaii-Aleytain";
                break;
           case "Minneapolis":
                timeZoneLabel.Text = "Central";
           case "San Franciso":
                timeZoneLabel.Text = "Mountain";
                break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
