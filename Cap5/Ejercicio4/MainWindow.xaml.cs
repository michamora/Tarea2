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

//Ejercicio4 Cap5 - Factorial de un numero

namespace Ejercicio4
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

         private void Calcular()
        {
            NumeroTextBox.Text = Console.ReadLine();
            
            
        }
     private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
           int fac=1,x,n;
            string num;
            x = 1;

            num = (NumeroTextBox.Text);

            n = int.Parse(num);
            while (x <= n)
            {
                fac = fac * x;
                x = x + 1;
            }
            Factorial.Text = fac.ToString();
            
        }
    }
}

