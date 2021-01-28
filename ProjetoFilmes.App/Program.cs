using System;
using System.Linq;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.App.Dados;
using ProjetoFilmes.App.DAO;
using ProjetoFilmes.App.Entidades;

namespace ProjetoFilmes.App
{
    class Program
    {
        static void Main()
        {
            using (var contexto = new FilmesContext())
            {
                contexto.LogSQLToConsole();

                var categorias = contexto.Categorias
                    .Include(c => c.Filmes)
                    .ThenInclude(fc => fc.Filme);

                foreach (var c in categorias)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Filmes da categoria {c}:");
                    foreach (var fc in c.Filmes)
                    {
                        Console.WriteLine(fc.Filme);
                    }
                }

                Console.ReadKey();
            }
        }
    }
}
