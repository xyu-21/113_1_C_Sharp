namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void btnShowback_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true; //�]�wvisible�ݩʬ���
            ptxFront.Visible = false;
        }
        //��ܼ��J�P����
        private void btnShowfront_Click(object sender, EventArgs e)
        {
            ptxFront.Visible = true;
            ptxBack.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
