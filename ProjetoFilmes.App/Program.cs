using System;
using ProjetoFilmes.App.Dados;

namespace ProjetoFilmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var repo = new FilmesContext())
            {
                foreach(var ator in repo.Atores)
                {
                    Console.WriteLine(ator);
                }
                Console.ReadKey();
            }
            
        }
    }
}