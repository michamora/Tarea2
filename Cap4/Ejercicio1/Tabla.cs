using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio1{
    public class Tabla{
       

        [Key]

        public int Numeroid { get; set;}
        
        public string? Nombre { get; set;}
        public Tabla( string? nombre)
        {
            Tabla tabla = this; Nombre = nombre;
        }
        
            }
    }
