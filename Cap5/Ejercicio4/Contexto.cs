using System;
using Microsoft.EntityFrameworkCore;
using Ejercicio4;

public class Contexto : DbContext
{
  public DbSet<Factorial> Factorial { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
      optionsBuilder.UseSqlite("Data Source = Factorial.db");
  }
}
