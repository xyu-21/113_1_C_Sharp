namespace A111221046_HW2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double cash;
            string point;

            cash = double.Parse(txtCash.Text);

            try
            {

                    if (cash >= 0 && cash <= 100)
                    {
                        point = "1";
                    }
                    else if (cash >= 101 && cash <= 500)
                    {
                        point = "5";
                    }
                    else if (cash >= 501 && cash <= 1000)
                    {
                        point = "10";
                    }
                    else if (cash >= 1001 && cash <= 2000)
                    {
                        point = "15";
                    }
                    else if (cash >= 2001)
                    {
                        point = "20";
                    }
                    else
                    {
                        point = "20";
                    }
                lblTotal.Text = point.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCash.Text = "";
            lblTotal.Text = "";

            txtCash.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
