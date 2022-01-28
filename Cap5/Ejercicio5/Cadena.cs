using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio5{
    public class Cadena{
       

        [Key]

        public int Numeroid { get; set;}
        
        public string? Nombre { get; set;}
        public Cadena( string? nombre)
        {
            Cadena cadena = this; Nombre = nombre;
        }
    }
}