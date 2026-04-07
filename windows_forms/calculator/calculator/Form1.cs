namespace calculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDecide_click(object sender, EventArgs e)
        {
            string FirstNum = tBxFirstNum.Text;
            string SecondNum = tBxSecondNum.Text;

            if (string.IsNullOrEmpty(FirstNum) || string.IsNullOrEmpty(SecondNum))
            {
                lblAnswer.BackColor = Color.Red;
                lblAnswer.Text = "Error";
                return;
            }

            if (int.TryParse(FirstNum, out int num1) &&
                int.TryParse(SecondNum, out int num2))
            {
                lblAnswer.BackColor = Color.White;
                lblAnswer.Text = $"{num1} + {num2} = {num1 + num2}";
            }
            else
            {
                lblAnswer.BackColor = Color.Red;
                lblAnswer.Text = "Error";
            }
        }

        private void btnMultiplay_click(object sender, EventArgs e)
        {
            string FirstNum = tBxFirstNum.Text;
            string SecondNum = tBxSecondNum.Text;

            if (string.IsNullOrEmpty(FirstNum) || string.IsNullOrEmpty(SecondNum))
            {
                lblAnswer.BackColor = Color.Red;
                lblAnswer.Text = "Error";
                return;
            }

            if (int.TryParse(FirstNum, out int num1) &&
                int.TryParse(SecondNum, out int num2))
            {
                lblAnswer.BackColor = Color.White;
                lblAnswer.Text = $"{num1} * {num2} = {num1 * num2}";
            }
            else
            {
                lblAnswer.BackColor = Color.Red;
                lblAnswer.Text = "Error";
            }
        }

        private void btnDifference_click(object sender, EventArgs e)
        {
            string FirstNum = tBxFirstNum.Text;
            string SecondNum = tBxSecondNum.Text;

            if (string.IsNullOrEmpty(FirstNum) || string.IsNullOrEmpty(SecondNum))
            {
                lblAnswer.BackColor = Color.Red;
                lblAnswer.Text = "Error";
                return;
            }

            if (int.TryParse(FirstNum, out int num1) &&
                int.TryParse(SecondNum, out int num2))
            {
                lblAnswer.BackColor = Color.White;
                lblAnswer.Text = $"{num1} - {num2} = {num1 - num2}";
            }
            else
            {
                lblAnswer.BackColor = Color.Red;
                lblAnswer.Text = "Error";
            }
        }

        private void btnDivide_click(object sender, EventArgs e)
        {
            string FirstNum = tBxFirstNum.Text;
            string SecondNum = tBxSecondNum.Text;

            if (string.IsNullOrEmpty(FirstNum) || string.IsNullOrEmpty(SecondNum))
            {
                lblAnswer.BackColor = Color.Red;
                lblAnswer.Text = "Error";
                return;
            }

            if (int.TryParse(FirstNum, out int num1) &&
                int.TryParse(SecondNum, out int num2))
            {
                if (num2 == 0)
                {
                    lblAnswer.BackColor = Color.Red;
                    lblAnswer.Text = "Error";
                    return;
                }

                lblAnswer.BackColor = Color.White;
                lblAnswer.Text = $"{num1} / {num2} = {num1 / num2}";
            }
            else
            {
                lblAnswer.BackColor = Color.Red;
                lblAnswer.Text = "Error";
            }
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
