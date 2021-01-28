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

            
            Console.WriteLine(ClassificacaoIndicativa.Livre.ParaString());
            Console.WriteLine("G".ParaValor());
            Console.ReadKey();
            //using (var contexto = new FilmesContext())
            //{
            //    contexto.LogSQLToConsole();

            //    var idiomas = contexto.Idiomas
            //        .Include(i => i.FilmesFalados);

            //    foreach (var idioma in idiomas)
            //    {
            //        Console.WriteLine(idioma);

            //        foreach (var filme in idioma.FilmesFalados)
            //        {
            //            Console.WriteLine(filme);
            //        }
            //        Console.WriteLine("\n");
            //    }

            //    Console.ReadKey();
            //}
        }
    }
}
