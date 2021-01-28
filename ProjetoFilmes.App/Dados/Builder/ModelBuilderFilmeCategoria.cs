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
    class ModelBuilderFilmeCategoria : IEntityTypeConfiguration<FilmeCategoria>
    {
        public void Configure(EntityTypeBuilder<FilmeCategoria> builder)
        {
            builder.ToTable("Film_Category");
            builder.Property<int>("Film_Id");
            builder.Property<byte>("Category_Id");
            builder.HasKey("Film_Id", "Category_Id");

            builder
                .HasOne(fc => fc.Categoria)
                .WithMany(c => c.Filmes)
                .HasForeignKey("Category_Id");

            builder
                .HasOne(fc => fc.Filme)
                .WithMany(f => f.Categorias)
                .HasForeignKey("Film_Id");
        }
    }
}
