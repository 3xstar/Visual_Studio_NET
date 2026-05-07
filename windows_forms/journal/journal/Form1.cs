namespace journal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = tBxLogin.Text;
            string password = tBxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                lblError.Visible = true;
                return;
            }

            if(Parser.GetAccess(login, password))
            {
                lblError.Visible = false;
                MainWindow window = new MainWindow();
                window.Show();
                Hide();
            }
            else
            {
                lblError.Visible = true;
                return;
            }
        }
    }
}
