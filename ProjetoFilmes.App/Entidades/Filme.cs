using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilmes.App.Entidades
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        public short Duracao { get; set; }
        public IList<FilmeAtor> Atores { get; set; }

        public Filme()
        {
            Atores = new List<FilmeAtor>();
        }
        public override string ToString()
        {
            return $"Filme: {Titulo}, Ano: {AnoLancamento}, Duração :{Duracao}";
        }

    }
}
