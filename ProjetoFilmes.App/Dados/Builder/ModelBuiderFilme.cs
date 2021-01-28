using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFilmes.App.Entidades;
using System;

namespace ProjetoFilmes.App.Dados.Builder
{
    class ModelBuiderFilme: IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder
                .ToTable("Film");

            builder
                .Property(f => f.Id)
                .HasColumnName("Film_Id");

            builder
                .Property(f => f.Titulo)
                .HasColumnName("Title")
                .HasColumnType("Varchar(255)")
                .IsRequired();

            builder
                .Property(f => f.Descricao)
                .HasColumnName("Description")
                .HasColumnType("Text");

            builder
                .Property(f => f.AnoLancamento)
                .HasColumnName("Release_Year")
                .HasColumnType("Varchar(4)");

            builder
                .Property(f => f.Duracao)
                .HasColumnName("Length");                

            //Shadow Property
            builder
                .Property<DateTime>("Last_Update")
                .HasColumnType("DateTime")
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder.Property<byte>("language_id");
            builder.Property<byte>("original_language_id");

            builder
                .HasOne(f => f.IdiomaFalado)
                .WithMany(i => i.FilmesFalados)
                .HasForeignKey("language_id");

            builder
                .HasOne(f => f.IdiomaOriginal)
                .WithMany(i => i.FilmesOriginais)
                .HasForeignKey("original_language_id");
        }
    }
}