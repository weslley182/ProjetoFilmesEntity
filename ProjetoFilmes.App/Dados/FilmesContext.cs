using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.App.Dados.Builder;
using ProjetoFilmes.App.Entidades;

namespace ProjetoFilmes.App.Dados
{
    public class FilmesContext: DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> Elenco { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjetoFilmes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ModelBuiderAtor());
            modelBuilder.ApplyConfiguration(new ModelBuiderFilme());
            modelBuilder.ApplyConfiguration(new ModelBuilderFilmeAtor());
            modelBuilder.ApplyConfiguration(new ModelBuilderCategoria());
            modelBuilder.ApplyConfiguration(new ModelBuilderFilmeCategoria());
            modelBuilder.ApplyConfiguration(new ModelBuilderIdioma());
        }        
    }    
}
