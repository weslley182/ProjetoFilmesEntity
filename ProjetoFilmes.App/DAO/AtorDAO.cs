using ProjetoFilmes.App.Dados;
using ProjetoFilmes.App.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoFilmes.App.Interface;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFilmes.App.DAO
{
    class AtorDAO: IDAO<Ator>, IDisposable
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

        public IList<Ator> ListarTodos()
        {
            return _context.Atores.ToList();
        }

        public IQueryable<Ator> BuscarUltimosAtoresInseridos(int quantidade)
        {
            _context.LogSQLToConsole();
            //listar os 10 atores modificados recentemente 
            return _context.Atores
                .OrderByDescending(a => EF.Property<DateTime>(a, "Last_Update"))
                .Take(quantidade);

        }
    }
}
