using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio4{
    public class Factorial{
         

        [Key]

        public int Numeroid { get; set;}
        
        public string? Nombre { get; set;}
        public Factorial( string? nombre)
        {
            Factorial factorial = this; Nombre = nombre;
        }
    }
}