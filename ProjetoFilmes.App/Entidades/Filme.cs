﻿using ProjetoFilmes.App.Enumerado;
using ProjetoFilmes.App.Extensions;
using System.Collections.Generic;

namespace ProjetoFilmes.App.Entidades
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        public short Duracao { get; set; }
        public string TextoClassificacao { get; private set; }
        public ClassificacaoIndicativa Classificacao
        {
            get { return TextoClassificacao.ParaValor(); }
            set { TextoClassificacao = value.ParaString(); }
        }
        public IList<FilmeAtor> Atores { get; set; }
        public IList<FilmeCategoria> Categorias { get; set; }
        public Idioma IdiomaFalado { get; set; }
        public Idioma IdiomaOriginal { get; set; }

        public Filme()
        {
            Atores = new List<FilmeAtor>();
            Categorias = new List<FilmeCategoria>();
        }
        public override string ToString()
        {
            return $"Filme: {Titulo}, Ano: {AnoLancamento}, Duração :{Duracao}";
        }

    }
}
