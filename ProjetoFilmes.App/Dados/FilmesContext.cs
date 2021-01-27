using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.App.Dados.Builder;
using ProjetoFilmes.App.Entidades;

namespace ProjetoFilmes.App.Dados
{
    public class FilmesContext: DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjetoFilmes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelBuiderAtor.ConfigurarAtor(modelBuilder);
        }

        
    }

    
}
