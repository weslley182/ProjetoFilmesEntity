using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFilmes.App.Entidades;
using System;

namespace ProjetoFilmes.App.Dados.Builder
{
    internal class ModelBuilderCliente : ModelBuilderPessoa<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.ToTable("Customer");

            builder
                .Property(c => c.Id)
                .HasColumnName("Customer_Id");

            builder
                .Property<DateTime>("Create_Date")
                .HasColumnType("DateTime")
                .HasDefaultValueSql("Getdate()")
                .IsRequired();
        }
    }
}