using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ejercicio4;

public class FactorialBLL
{
      public static bool Calcular(Factorial factorial)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try{
                contexto.Factorial.Add(factorial);
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