namespace A111221046_HW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblShow.Text = "����A";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblShow.Text = "���A";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblShow.Text = "����A";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblShow.Text = "�®�A";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblShow.Text = "�®�2";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}