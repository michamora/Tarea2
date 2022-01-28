using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ejercicio2;

public class NumeroBLL
{
    public static bool Calcular(Numero numero)
    {
        bool paso = false;
        Contexto contexto = new Contexto();

        try{
            contexto.Numero.Add(numero);
            paso = contexto.SaveChanges() > 0;
        }
        catch (Exception)
        {
            throw;
        }
        finally 
        {
            contexto.Dispose();
        }
        return paso;
    }
}