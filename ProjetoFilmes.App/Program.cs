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

                //SelecaoEntity(contexto);
                SelecaoFrom(contexto);

                Console.ReadKey();
            }
        }

        private static void SelecaoFrom(FilmesContext contexto)
        {
            const string sql =
                @"select a.*
                    from actor a
                        inner join
                    (select top 5 a.actor_id, count(*) as total
                    from actor a
                        inner join film_actor fa on fa.actor_id = a.actor_id
                    group by a.actor_id
                    order by total desc) filmes on filmes.actor_id = a.actor_id";

            const string sqlComView =
                 @"select a.* from actor a
                    inner join top5_most_starred_actors filmes on filmes.actor_id = a.actor_id";

            var atoresMaisAtuantes = contexto.Atores
                .FromSql(sqlComView)
                .Include(a => a.Filmografia);
                

            foreach (var ator in atoresMaisAtuantes)
            {
                Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes.");
            }
        }

        private static void SelecaoEntity(FilmesContext contexto)
        {
            var atoresMaisAtuantes = contexto.Atores
                                .Include(a => a.Filmografia)
                                .OrderByDescending(a => a.Filmografia.Count)
                                .Take(5);

            foreach (var ator in atoresMaisAtuantes)
            {
                Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes");
            }
        }
    }
}
