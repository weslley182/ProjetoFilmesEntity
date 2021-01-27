using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFilmes.App.Entidades
{
    [Table("Actor")]
    public class Ator
    {
        [Column("Actor_Id")]
        public int Id { get; set; }

        [Column("First_Name")]
        public string PrimeiroNome { get; set; }
        
        [Column("Last_Name")]
        public string UltimoNome { get; set; }

        public override string ToString()
        {
            return $"Nome do ator:{PrimeiroNome} {UltimoNome}";
        }
    }
}