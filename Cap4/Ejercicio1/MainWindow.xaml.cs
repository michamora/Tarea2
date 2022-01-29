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


//Ejercicio1 Cap4 - Tabla de multiplicar 1 al 10

namespace Ejercicio1
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
           
            int n = int.Parse(NumeroTextBox.Text);
            int r;
            
            
            //proceso
            for (int x = 1; x <= 10; x++)
            {
                r = n * x;
                Tabla2.Items.Add($"Resultado {n} x {x} = "+ r);
                
            }
          
      
        }
    }
    }


             
        
    
    

