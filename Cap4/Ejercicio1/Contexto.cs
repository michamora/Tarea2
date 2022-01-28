using System;
using Microsoft.EntityFrameworkCore;
using Ejercicio1;

public class Contexto : DbContext
{
  public DbSet<Tabla> Tabla { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
      optionsBuilder.UseSqlite("Data Source = Tabla.db");
  }
}