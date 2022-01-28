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
            Factorial fac = new Factorial(NumeroTextBox.Text);

          var paso = FactorialBLL.Calcular(fac);

          if (paso)
          {
              Calcular();
           String numero;
            int num,resultado = 0;

            Console.WriteLine("Introduzca el Numero: ");
            numero = Console.ReadLine();

            num = Convert.ToInt32(numero);

            resultado = Factorial(num);

            Console.WriteLine("Resultado: {0}", resultado);
        }

        static int Factorial(int a)
        {
            int numi = 1, numf = 2, i = 1;

            do
            {

                numi = numi * numf;
                numf = numf + 1;
                i++;
    

        } while (i < a);

            return  numi;

        }
      
        }
    }
}

