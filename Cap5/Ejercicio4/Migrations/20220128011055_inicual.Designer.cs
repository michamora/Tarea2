﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ejercicio4.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220128011055_inicual")]
    partial class inicual
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Ejercicio4.Factorial", b =>
                {
                    b.Property<int>("Numeroid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Numeroid");

                    b.ToTable("Factorial");
                });
#pragma warning restore 612, 618
        }
    }
}