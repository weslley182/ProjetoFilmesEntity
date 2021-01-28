using System.Collections.Generic;

namespace ProjetoFilmes.App.Entidades
{
    public class Categoria
    {
        public byte Id { get; set; }
        public string Nome { get; set; }

        public IList<FilmeCategoria> Filmes { get; set; }
        public Categoria()
        {
            Filmes = new List<FilmeCategoria>();
        }

        public override string ToString()
        {
            return $"Categoria: {Nome}.";
        }
    }
}
