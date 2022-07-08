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

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string value=(string)button.Content;

            if (IsNumber(value))
            {
                HandleNumber(value);
            }
            else if (value=="C" || value =="CE")
            {
                HandleClear(value);
            }
        }

        public void HandleNumber(string value )
        {
            if(string.IsNullOrEmpty(Screen.Text))
            {
                Screen.Text = value;
            }
            else
            {
                Screen.Text += value;
            }
        }

        //auxiliares metodos

        private bool IsNumber(string possibleNumber)
        {
            return double.TryParse(possibleNumber, out _);
        }


        private void HandleClear(string value)
        {
            if (value == "C")
            {
                if(Screen.Text.Length > 1)
                {
                    Screen.Text=Screen.Text.Substring(0, Screen.Text.Length - 1);
                }
                else
                {
                    Screen.Clear();
                }
            }
            else if (value == "CE")
            {
                Screen.Clear();
            }
        }
    }
}
