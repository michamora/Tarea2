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

//Ejercicio 5 cap 5- Cadena de un numero escrito en palabras

namespace Ejercicio5
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
            Cadena cad= new Cadena(NumTextBox.Text);

          var paso = CadenaBLL.Calcular(cad);

          if (paso)
          {
             string num,convertido =" ";
            double numero;

            Console.Write("Digite el numero a convertir: ");
            num = Console.ReadLine();
            numero = Convert.ToDouble(num);
            convertido = convertir(numero);

            Console.WriteLine("El numero {0} convertido a letras es: {1}", numero, convertido);
        }

         static string convertir(double numero)
        {
            string texto = "";

            numero = Math.Truncate(numero);

            if (numero == 0)
                texto = "CERO";
            else if (numero == 1)
                texto = "UNO";
            else if (numero == 2)
                texto = "DOS";
            else if (numero == 3)
                texto = "TRES";
            else if (numero == 4)
                texto = "CUATRO";
            else if (numero == 5)
                texto = "CINCO";
            else if (numero == 6)
                texto = "SEIS";
            else if (numero == 7)
                texto = "SIETE";
            else if (numero == 8)
                texto = "OCHO";
            else if (numero == 9)
                texto = "NUEVE";
            else if (numero == 10)
                texto = "DIEZ";
            else if (numero == 11)
                texto = "ONCE";
            else if (numero == 12)
                texto = "DOCE";
            else if (numero == 13)
                texto = "TRECE";
            else if (numero == 14)
                texto = "CATORCE";
            else if (numero == 15)
                texto = "QUINCE";
            else if (numero < 20)
                texto = "DIECI" + (numero - 10).ToString();
            else if (numero == 20)
                texto = "VEINTE";
            else if (numero < 30)
                texto = "VEINTI" + (numero - 20).ToString();
            else if (numero == 30)
                texto = "TREINTA";
            else if (numero == 40)
                texto = "CUARENTA";
            else if (numero == 50)
                texto = "CINCUENTA";
            else if (numero == 60)
                texto = "SESENTA";
            else if (numero == 70)
                texto = "SETENTA";
            else if (numero == 80)
                texto = "OCHENTA";
            else if (numero == 90)
                texto = "NOVENTA";

            else if (numero < 100)
                texto = (Math.Truncate(numero / 10) * 10).ToString() + " Y " + (numero % 10).ToString();
            else if (numero == 100)
                texto = "CIEN";
            else if (numero < 200)
                texto = "CIENTO " + (numero - 100).ToString();
            else if ((numero == 200) || (numero == 300) || (numero == 400) || (numero == 600) || (numero == 800))
                texto = (Math.Truncate(numero / 100)).ToString() + "CIENTOS";

            return texto;
    }   }
}
}