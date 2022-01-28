using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio2{
    public class Numero{
        [Key]

        public int Numeroid {get; set;}

        public int potencia {get; set;}

        public string? Nombre { get; set;}
        public Numero( string? nombre)
        {
            Numero numero = this; Nombre = nombre;
        }
    }
}