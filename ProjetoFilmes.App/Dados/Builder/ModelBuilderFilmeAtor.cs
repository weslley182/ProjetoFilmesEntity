using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFilmes.App.Entidades;
using System;

namespace ProjetoFilmes.App.Dados.Builder
{
    class ModelBuilderFilmeAtor : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            builder
                .ToTable("Film_Actor");

            //shadow
            builder
                .Property<int>("Film_Id");
            
            builder
                .Property<int>("Actor_Id");            
            
            builder
                .Property<DateTime>("Last_Update")
                .IsRequired()
                .HasColumnType("DateTime")
                .HasDefaultValue(DateTime.Now);
            //shadow

            builder.HasKey("Film_Id", "Actor_Id");

            builder
                .HasOne(fa => fa.Filme)
                .WithMany(f => f.Atores)
                .HasForeignKey("Film_Id");

            builder
                .HasOne(fa => fa.Ator)
                .WithMany(a => a.Filmografia)
                .HasForeignKey("Actor_Id");

        }
    }
}
