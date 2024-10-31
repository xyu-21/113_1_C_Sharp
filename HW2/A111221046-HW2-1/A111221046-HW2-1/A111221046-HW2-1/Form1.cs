namespace A111221046_HW2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal soldA, soldB, soldC, total;
            const decimal TICKETS_A = 15m;
            const decimal TICKETS_B = 12m;
            const decimal TICKETS_C = 9m;

            try
            {
                soldA = decimal.Parse(txtSoldA.Text);
                soldB = decimal.Parse(txtSoldB.Text);
                soldC = decimal.Parse(txtSoldC.Text);
                total = (soldA * TICKETS_A) + (soldB * TICKETS_B) + (soldC * TICKETS_C);

                lblA.Text = (soldA * TICKETS_A).ToString("c");
                lblB.Text = (soldB * TICKETS_B).ToString("c");
                lblC.Text = (soldC * TICKETS_C).ToString("c");
                lblTotal.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("輸入格式不正確");
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtSoldA.Text = "";
            txtSoldB.Text = "";
            txtSoldC.Text = "";
            lblA.Text = "";
            lblB.Text = "";
            lblC.Text = "";
            lblTotal.Text = "";


            txtSoldA.Focus();
        }
    }
}
