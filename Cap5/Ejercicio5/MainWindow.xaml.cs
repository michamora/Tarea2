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
        private object texto;

        public MainWindow()
        {
            InitializeComponent();
        }

        
     

         public void Main(double numero)
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
      
        
             
               
        }
        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
          
            string num;
            double numero;
          
            num = Convert.ToString(NumTextBox.Text); //Numero a convertir
            numero = Convert.ToDouble(num);

            texto = Convert.ToString(NumeroConvertido.Text);
            
            NumeroConvertido.Text = texto.ToString();
        }


    }
    }
