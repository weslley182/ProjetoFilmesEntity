using ProjetoFilmes.App.Dados;
using ProjetoFilmes.App.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFilmes.App.Interface;

namespace ProjetoFilmes.App.DAO
{
    class AtorDAO: IAtorDAO, IDisposable
    {
        private readonly FilmesContext _context;
        public AtorDAO()
        {
            _context = new FilmesContext();
        }

        public void Adicionar(Ator ator)
        {
            _context.Atores.Add(ator);
            // _context.Entry(ator).Property("Last_Update").CurrentValue = DateTime.Now;

            _context.SaveChanges();
        }
        public void Atualizar(Ator ator)
        {
            _context.Atores.Update(ator);
            //_context.Entry(ator).Property("Last_Update").CurrentValue = DateTime.Now;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Remover(Ator ator)
        {
            _context.Atores.Remove(ator);
            _context.SaveChanges();
        }

        public IList<Ator> Atores()
        {
            return _context.Atores.ToList();
        }
    }
}
