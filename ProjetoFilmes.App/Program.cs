using System;
using ProjetoFilmes.App.Dados;
using ProjetoFilmes.App.DAO;
using ProjetoFilmes.App.Entidades;

namespace ProjetoFilmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var ator = new Ator();
            ator.PrimeiroNome = "Tom";
            ator.UltimoNome = "Hanks";

            var dao = new AtorDAO();

            dao.Adicionar(ator);
            Console.ReadKey();

            foreach(var at in dao.Atores())
            {
                Console.WriteLine(at);
            }
        }
    }
}
