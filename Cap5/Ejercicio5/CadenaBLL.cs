using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ejercicio5;

public class CadenaBLL
{
      public static bool Calcular(Cadena cadena)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try{
                contexto.Cadena.Add(cadena);
                paso = contexto.SaveChanges()>0;
               

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