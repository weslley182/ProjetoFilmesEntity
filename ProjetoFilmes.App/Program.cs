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

                var idiomas = contexto.Idiomas.ToList();



                foreach (var c in idiomas)
                {

                    Console.WriteLine(c);

                }

                Console.ReadKey();
            }
        }
    }
}
