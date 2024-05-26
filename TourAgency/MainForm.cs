namespace TourAgency
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            this.Hide();
            authForm.FormClosed += (s, args) => this.Close();
            authForm.Show();
        }
    }
}
