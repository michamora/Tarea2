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
          int cant = 0, min = 0, max = 0, edad ;

            cant = int.Parse(CantTextBox.Text);
            

            for (int i = 0; i < cant; i++)
            {
                edad = int.Parse(EdadTextBox.Text);
               
                
                if (i == 0)
                    min = max = edad;
                else if (edad > max)
                    max = edad;
                else if (edad < min)
                    min = edad;
            }
            
            Edad1.Items.Add("Edad Mayor"+ max);
            Edad2.Items.Add("Edad Menor"+ min);
            
    }
        }
    }



