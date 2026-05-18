using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            foreach(var item in MainGrid.Children)
            {
                if (item is Button)
                {
                    ((Button)item).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btnContent = btn.Content.ToString();

            if(btnContent == "clear")
            {
                lblAnswer.Content = "";
            }
            else if(btnContent == "=")
            {
                string value = new DataTable().Compute(lblAnswer.Content.ToString(), null).ToString();
                lblAnswer.Content = value;
            }
            else
            {
                lblAnswer.Content += btnContent;
            }
        }
    }
}
