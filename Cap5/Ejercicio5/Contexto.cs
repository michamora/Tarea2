using System;
using Microsoft.EntityFrameworkCore;
using Ejercicio5;

public class Contexto : DbContext
{
  public DbSet<Cadena> Cadena { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
      optionsBuilder.UseSqlite("Data Source = Cadena.db");
  }
}
