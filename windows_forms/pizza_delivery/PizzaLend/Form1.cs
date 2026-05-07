using SQLite;

namespace PizzaLend
{
    public partial class PizzaTime : Form
    {
        // C#
        public PizzaTime()
        {
            InitializeComponent();
            EnsureDatabase(); // <--- добавить
            lblLoginError.Visible = false;
            lblRegisterError.Visible = false;
            tabOrder.Enabled = false;
            tabPay.Enabled = false;
        }

        private void EnsureDatabase()
        {
            using (var db = new SQLiteConnection(Variables.filePath))
            {
                db.CreateTable<DBusers>();
            }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tBxEmail.Text;
            string password = tBxPassword.Text;

            if (string.IsNullOrEmpty(email)) tBxEmail.BackColor = Color.Red;
            else tBxEmail.BackColor = Color.White;

            if (string.IsNullOrEmpty(password)) tBxPassword.BackColor = Color.Red;
            else tBxPassword.BackColor = Color.White;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) return;

            var db = new SQLiteConnection(Variables.filePath);
            var users = db.Table<DBusers>().Where(u => u.Email == email && u.Password == password).ToList();

            if (users.Count == 0) return;
            else
            {
                tabOrder.Enabled = true;
                tabPay.Enabled = true;
                tabControl.SelectTab(2);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string typeOfPizza = comboBoxPizzas.Text;
            int countPizzas = (int)numericUpDownCount.Value;

            if (string.IsNullOrEmpty(typeOfPizza) || countPizzas == 0) return;

            List<string> addities = new List<string>();

            foreach (object it in ListBoxAddities.CheckedItems)
                addities.Add(it?.ToString() ?? string.Empty);

            Pizza newPizza = new Pizza(typeOfPizza, countPizzas, addities);
            comboBoxOrder.Items.Add(newPizza.GetFullPizza());

            Variables.pizzas.Add(newPizza);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Variables.pizzas.Count == 0)
            {
                MessageBox.Show($"order is empty");
                return;
            }

            string message = string.Empty;

            foreach (Pizza pizza in Variables.pizzas)
            {
                message += pizza.GetFullPizza();
            }

            MessageBox.Show($"Подтвердите заказ: \n {message}");
            tabControl.SelectTab(3);
        }

        private void btnOrderPay_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonCard_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonCard.Checked) Variables.paymentMethod = "Card";
            else if(radioButtonCash.Checked) Variables.paymentMethod = "Cash";

            MessageBox.Show($"Вы выбрали способ оплаты: {Variables.paymentMethod}");
        }
    }
}
