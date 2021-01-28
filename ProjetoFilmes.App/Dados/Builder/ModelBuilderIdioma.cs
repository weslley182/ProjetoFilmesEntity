using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFilmes.App.Entidades;
using System;

namespace ProjetoFilmes.App.Dados.Builder
{
    class ModelBuilderIdioma : IEntityTypeConfiguration<Idioma>
    {
        public void Configure(EntityTypeBuilder<Idioma> builder)
        {
            builder.ToTable("Language");

            builder                
                .Property(i => i.Id)
                .HasColumnName("language_Id");

            builder
                .Property(i => i.Nome)
                .HasColumnName("Name")
                .HasColumnType("char(20)")
                .IsRequired();

            builder
                .Property<DateTime>("Last_Update")
                .HasColumnType("DateTime")
                .HasDefaultValue(DateTime.Now);
        }
    }
}
