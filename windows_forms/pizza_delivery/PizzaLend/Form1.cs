using SQLite;

namespace PizzaLend
{
    public partial class PizzaTime : Form
    {
        public PizzaTime()
        {
            InitializeComponent();
            lblLoginError.Visible = false;
            lblRegisterError.Visible = false;
            tabOrder.Enabled = false;
            tabPay.Enabled = false;
        }

        private void PizzaTime_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Variables.filePath))
            {
                var db = new SQLiteConnection(Variables.filePath);
                db.CreateTable<DBusers>();
                db.Close();
            }
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string name = tBxRegisterName.Text;
            string email = tBxRegisterEmail.Text;
            string password = tBxRegisterPassword.Text;

            if (string.IsNullOrEmpty(name)) tBxRegisterName.BackColor = Color.Red;
            else tBxRegisterName.BackColor = Color.White;

            if (string.IsNullOrEmpty(email)) tBxRegisterEmail.BackColor = Color.Red;
            else tBxRegisterEmail.BackColor = Color.White;

            if (string.IsNullOrEmpty(password)) tBxRegisterPassword.BackColor = Color.Red;
            else tBxRegisterPassword.BackColor = Color.White;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) return;

            DBusers newUser = new DBusers(name, email, password);

            var db = new SQLiteConnection(Variables.filePath);

            var users = db.Table<DBusers>().ToList();

            foreach (var user in users)
            {
                if (user.Email == newUser.Email)
                {
                    lblRegisterError.Visible = true;
                    return;
                }
            }

            lblRegisterError.Visible = false;
            db.Insert(newUser);
            db.Close();
        }
    }
}
