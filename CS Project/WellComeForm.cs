namespace CS_Project
{
    public partial class WellComeForm : Form
    {
        public WellComeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAccountForm Form=new CreateAccountForm();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm Form = new LoginForm();
            this.Hide();
            Form.ShowDialog();
            this.Show();
        }
    }
}