using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            string num1 = tbxNum1.Text;
            string num2 = tbxNum2.Text;

            if(float.TryParse(num1, out float num1f) && float.TryParse(num2, out float num2f))
            {
                float result = num1f + num2f;
                lblAnswer.Content = result.ToString();
            }
        }

        private void btnDif_Click(object sender, RoutedEventArgs e)
        {
            string num1 = tbxNum1.Text;
            string num2 = tbxNum2.Text;

            if (float.TryParse(num1, out float num1f) && float.TryParse(num2, out float num2f))
            {
                float result = num1f - num2f;
                lblAnswer.Content = result.ToString();
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            string num1 = tbxNum1.Text;
            string num2 = tbxNum2.Text;

            if (float.TryParse(num1, out float num1f) && float.TryParse(num2, out float num2f))
            {
                float result = num1f / num2f;
                lblAnswer.Content = result.ToString();
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            string num1 = tbxNum1.Text;
            string num2 = tbxNum2.Text;

            if (float.TryParse(num1, out float num1f) && float.TryParse(num2, out float num2f))
            {
                float result = num1f * num2f;
                lblAnswer.Content = result.ToString();
            }
        }
    }
}
