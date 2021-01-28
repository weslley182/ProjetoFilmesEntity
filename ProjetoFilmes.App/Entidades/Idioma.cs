﻿using System.Collections.Generic;

namespace ProjetoFilmes.App.Entidades
{
    public class Idioma
    {
        public byte Id { get; set; }
        public string Nome { get; set; }
        public IList<Filme> FilmesFalados { get; set; }
        public IList<Filme> FilmesOriginais { get; set; }

        public Idioma()
        {
            FilmesFalados = new List<Filme>();
            FilmesOriginais = new List<Filme>();
        }
        public override string ToString()
        {
            return $"Idioma: {Nome}";
        }
    }
}
