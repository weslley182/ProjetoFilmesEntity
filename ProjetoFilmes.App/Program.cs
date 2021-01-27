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
            ator.PrimeiroNome = "Silvia";
            ator.UltimoNome = "Saint";

            var dao = new AtorDAO();

            dao.Adicionar(ator);            

            foreach(var at in dao.Atores())
            {
                Console.WriteLine(at);
            }

            Console.ReadKey();
        }
    }
}
