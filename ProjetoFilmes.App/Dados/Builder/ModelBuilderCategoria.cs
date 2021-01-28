using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFilmes.App.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilmes.App.Dados.Builder
{
    class ModelBuilderCategoria : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder
                .ToTable("Category");

            builder
                .Property(c => c.Id)
                .HasColumnName("Category_Id");

            builder
                .Property(c => c.Nome)
                .HasColumnName("Name")
                .HasColumnType("Varchar(25)")
                .IsRequired();

            //Shadow Property
            builder
                .Property<DateTime>("Last_Update")
                .HasColumnType("DateTime")
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
        }
    }
}
