namespace Tutorial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblShow.Text = "����";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblShow.Text = "�k��";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblShow.Text = "�w��";
        }
    }
}
