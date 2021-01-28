using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFilmes.App.Entidades;
using System;

namespace ProjetoFilmes.App.Dados.Builder
{
    public class ModelBuilderPessoa<T> : IEntityTypeConfiguration<T> where T : Pessoa
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder
                .Property(c => c.PrimeiroNome)
                .HasColumnName("First_Name")
                .HasColumnType("Varchar(45)")
                .IsRequired();

            builder
                .Property(c => c.UltimoNome)
                .HasColumnName("Last_Name")
                .HasColumnType("Varchar(45)")
                .IsRequired();

            builder
                .Property(c => c.Email)
                .HasColumnName("Email")
                .HasColumnType("Varchar(50");

            builder
                .Property(c => c.Ativo)
                .HasColumnName("Active");
            
            builder
                .Property<DateTime>("Last_Update")
                .HasColumnType("DateTime")
                .HasDefaultValueSql("Getdate()")
                .IsRequired();
        }        
    }
}