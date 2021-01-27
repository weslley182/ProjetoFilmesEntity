namespace ProjetoFilmes.App.Entidades
{

    public class Ator
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public override string ToString()
        {
            return $"Nome do ator:{PrimeiroNome} {UltimoNome}";
        }
    }
}