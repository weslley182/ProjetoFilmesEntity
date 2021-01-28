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
            builder.ToTable("Film");

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
                .HasDefaultValueSql("GetDate()")
                .IsRequired();

            builder.Property<byte>("Language_Id");
            builder.Property<byte?>("Original_Language_Id");

            builder
                .HasOne(f => f.IdiomaFalado)
                .WithMany(i => i.FilmesFalados)
                .HasForeignKey("Language_Id");

            builder
                .HasOne(f => f.IdiomaOriginal)
                .WithMany(i => i.FilmesOriginais)
                .HasForeignKey("Original_Language_Id");

            builder
                .Property(f => f.TextoClassificacao)
                .HasColumnName("Rating")
                .HasColumnType("Varchar(10)");

            builder.Ignore(f => f.Classificacao);
        }
    }
}