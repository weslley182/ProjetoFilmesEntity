using System;
using System.Linq;
using Alura.Filmes.App.Extensions;
using Microsoft.EntityFrameworkCore;
using ProjetoFilmes.App.Dados;
using ProjetoFilmes.App.DAO;
using ProjetoFilmes.App.Entidades;
using ProjetoFilmes.App.Enumerado;
using ProjetoFilmes.App.Extensions;

namespace ProjetoFilmes.App
{
    class Program
    {
        static void Main()
        {


            using (var contexto = new FilmesContext())
            {
                contexto.LogSQLToConsole();

                var atoresMaisAtuantes = contexto.Atores
                    .Include(a => a.Filmografia)
                    .OrderByDescending(a => a.Filmografia.Count)
                    .Take(5);

                foreach (var ator in atoresMaisAtuantes)
                {
                    Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes");
                }
                Console.ReadKey();
            }
        }
    }
}
