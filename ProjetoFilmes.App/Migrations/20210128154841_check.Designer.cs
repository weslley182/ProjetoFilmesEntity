﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProjetoFilmes.App.Dados;
using System;

namespace ProjetoFilmes.App.Migrations
{
    [DbContext(typeof(FilmesContext))]
    [Migration("20210128154841_check")]
    partial class check
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Actor_Id");

                    b.Property<DateTime>("Last_Update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("PrimeiroNome")
                        .IsRequired()
                        .HasColumnName("First_Name")
                        .HasColumnType("Varchar(45)");

                    b.Property<string>("UltimoNome")
                        .IsRequired()
                        .HasColumnName("Last_Name")
                        .HasColumnType("Varchar(45)");

                    b.HasKey("Id");

                    b.HasAlternateKey("PrimeiroNome", "UltimoNome");

                    b.HasIndex("UltimoNome")
                        .HasName("idx_actor_last_name");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.Categoria", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnName("Category_Id");

                    b.Property<DateTime>("Last_Update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("Varchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Film_Id");

                    b.Property<string>("AnoLancamento")
                        .HasColumnName("Release_Year")
                        .HasColumnType("Varchar(4)");

                    b.Property<string>("Classificacao")
                        .HasColumnName("Rating")
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("Descricao")
                        .HasColumnName("Description")
                        .HasColumnType("Text");

                    b.Property<short>("Duracao")
                        .HasColumnName("Length");

                    b.Property<byte>("Language_Id");

                    b.Property<DateTime>("Last_Update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<byte?>("Original_Language_Id");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("Title")
                        .HasColumnType("Varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Language_Id");

                    b.HasIndex("Original_Language_Id");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.FilmeAtor", b =>
                {
                    b.Property<int>("Film_Id");

                    b.Property<int>("Actor_Id");

                    b.Property<DateTime>("Last_Update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime")
                        .HasDefaultValueSql("GetDate()");

                    b.HasKey("Film_Id", "Actor_Id");

                    b.HasIndex("Actor_Id");

                    b.ToTable("Film_Actor");
                });

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.FilmeCategoria", b =>
                {
                    b.Property<int>("Film_Id");

                    b.Property<byte>("Category_Id");

                    b.HasKey("Film_Id", "Category_Id");

                    b.HasIndex("Category_Id");

                    b.ToTable("Film_Category");
                });

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.Idioma", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnName("language_Id");

                    b.Property<DateTime>("Last_Update")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTime")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("char(20)");

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.Filme", b =>
                {
                    b.HasOne("ProjetoFilmes.App.Entidades.Idioma", "IdiomaFalado")
                        .WithMany("FilmesFalados")
                        .HasForeignKey("Language_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjetoFilmes.App.Entidades.Idioma", "IdiomaOriginal")
                        .WithMany("FilmesOriginais")
                        .HasForeignKey("Original_Language_Id");
                });

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.FilmeAtor", b =>
                {
                    b.HasOne("ProjetoFilmes.App.Entidades.Ator", "Ator")
                        .WithMany("Filmografia")
                        .HasForeignKey("Actor_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjetoFilmes.App.Entidades.Filme", "Filme")
                        .WithMany("Atores")
                        .HasForeignKey("Film_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProjetoFilmes.App.Entidades.FilmeCategoria", b =>
                {
                    b.HasOne("ProjetoFilmes.App.Entidades.Categoria", "Categoria")
                        .WithMany("Filmes")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProjetoFilmes.App.Entidades.Filme", "Filme")
                        .WithMany("Categorias")
                        .HasForeignKey("Film_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
