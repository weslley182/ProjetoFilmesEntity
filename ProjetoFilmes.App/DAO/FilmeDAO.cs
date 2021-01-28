using ProjetoFilmes.App.Dados;
using ProjetoFilmes.App.Entidades;
using ProjetoFilmes.App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilmes.App.DAO
{
    class FilmeDAO : IDAO<Filme>, IDisposable
    {
        private readonly FilmesContext _context;
        public FilmeDAO()
        {
            _context = new FilmesContext();
        }

        public void Adicionar(Filme filme)
        {
            _context.Filmes.Add(filme);
            // _context.Entry(ator).Property("Last_Update").CurrentValue = DateTime.Now;

            _context.SaveChanges();
        }
        public void Atualizar(Filme filme)
        {
            _context.Filmes.Update(filme);
            //_context.Entry(ator).Property("Last_Update").CurrentValue = DateTime.Now;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Remover(Filme filme)
        {
            _context.Filmes.Remove(filme);
            _context.SaveChanges();
        }

        public IList<Filme> ListarTodos()
        {
            return _context.Filmes.ToList();
        }
    }
}
