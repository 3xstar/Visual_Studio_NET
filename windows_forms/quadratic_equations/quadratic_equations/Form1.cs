namespace quadratic_equations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDecide_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tBxA.Text);
            int b = int.Parse(tBxB.Text);
            int c = int.Parse(tBxC.Text);

            int D = b * b - 4 * a * c;

            double x1 = -b + Math.Sqrt(D) / (2 * a);
            double x2 = -b -  Math.Sqrt(D) / (2 * a);

            lblX1.Text = $"X1: {Convert.ToInt32(x1)}";
            lblX2.Text = $"X2: {Convert.ToInt32(x2)}";
        }
    }
}
