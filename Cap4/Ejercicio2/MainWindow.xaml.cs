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
        
        double num, pot, result;
        
        num = Convert.ToDouble(NumeroTextBox.Text);
        pot = Convert.ToDouble(PotenciaTextBox.Text);
        
        result = Math.Pow(num, pot);

        Resultado.Text = result.ToString();        
            
                
            }
            
        }
}
        
