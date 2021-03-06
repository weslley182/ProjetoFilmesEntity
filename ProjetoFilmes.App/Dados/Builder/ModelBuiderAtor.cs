﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFilmes.App.Entidades;
using System;

namespace ProjetoFilmes.App.Dados.Builder
{
    class ModelBuiderAtor: IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> builder)
        {
            builder
                .ToTable("Actor");

            builder
                .Property(a => a.Id)
                .HasColumnName("Actor_Id");

            builder
                .Property(a => a.PrimeiroNome)
                .HasColumnName("First_Name")
                .HasColumnType("Varchar(45)")
                .IsRequired();

            builder
                .Property(a => a.UltimoNome)
                .HasColumnName("Last_Name")
                .HasColumnType("Varchar(45)")
                .IsRequired();
            
            //Shadow Property
            builder
                .Property<DateTime>("Last_Update")
                .HasColumnType("DateTime")
                .HasDefaultValueSql("GetDate()")
                .IsRequired();

            builder
                .HasIndex(a => a.UltimoNome)
                .HasName("idx_actor_last_name");

            builder
                .HasAlternateKey(a => new { a.PrimeiroNome, a.UltimoNome });
        }
    }
}
