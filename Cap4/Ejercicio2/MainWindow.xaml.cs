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

//Ejercicio 2 Cap4 - Numero elevado a cualquier potencia

namespace Ejercicio2
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
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            Numero num = new Numero(NumeroTextBox.Text);

            var paso = NumeroBLL.Calcular(num);
            if (paso)
            {
               double nume, pot, resultado;

            Console.WriteLine("Introduce el numero que deseas elevar:");
            nume = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el numero de la potencia a elevar:");
            pot = Convert.ToDouble(Console.ReadLine());

            //proceso

            resultado = Math.Pow(nume, pot);

            Console.WriteLine("El resultado es:" + resultado);

            Console.ReadKey();
            }
            else 
            MessageBox.Show("Error");
        }
    }
}
