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
            var dao = new FilmeDAO();

            foreach(var item in dao.ListarTodos())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
