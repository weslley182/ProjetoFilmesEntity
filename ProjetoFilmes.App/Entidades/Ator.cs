using System.Collections.Generic;

namespace ProjetoFilmes.App.Entidades
{

    public class Ator
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public IList<FilmeAtor> Filmografia { get; set; }

        public Ator()
        {
            Filmografia = new List<FilmeAtor>();
        }
        public override string ToString()
        {
            return $"Nome do ator:{PrimeiroNome} {UltimoNome}";
        }
    }
}