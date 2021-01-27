﻿using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.App.Entidades;

namespace ProjetoFilmes.App.Dados.Builder
{
    class ModelBuiderAtor
    {
        public static void ConfigurarAtor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ator>()
                            .ToTable("Actor");

            modelBuilder.Entity<Ator>()
                .Property(a => a.Id)
                .HasColumnName("Actor_Id");

            modelBuilder.Entity<Ator>()
                .Property(a => a.PrimeiroNome)
                .HasColumnName("First_Name")
                .HasColumnType("Varchar(45)")
                .IsRequired();

            modelBuilder.Entity<Ator>()
                .Property(a => a.UltimoNome)
                .HasColumnName("last_Name")
                .HasColumnType("Varchar(45)")
                .IsRequired();

        }
    }
}