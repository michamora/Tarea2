using System;
using Microsoft.EntityFrameworkCore;
using Ejercicio2;

public class Contexto : DbContext
{
  public DbSet<Numero> Numero { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
      optionsBuilder.UseSqlite("Data Source = Numero.db");
  }
}
