using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ejercicio1;

public class TablaBLL
{
      public static bool Calcular(Tabla tabla)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try{
                contexto.Tabla.Add(tabla);
                paso = contexto.SaveChanges()>0;
                Console.WriteLine("Hola");

            }
            catch (Exception)
            {
                throw;

            }
            finally{
                contexto.Dispose();
            }
            
           return paso;
           
}
}