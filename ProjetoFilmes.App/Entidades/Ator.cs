using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFilmes.App.Entidades
{
    [Table("Actor")]
    public class Ator
    {
        [Column("Actor_Id")]
        public int Id { get; set; }

        [Required]
        [Column("First_Name", TypeName = "Varchar(45)")]
        public string PrimeiroNome { get; set; }
        
        [Required]
        [Column("Last_Name", TypeName = "varchar(45)")]        
        public string UltimoNome { get; set; }

        public override string ToString()
        {
            return $"Nome do ator:{PrimeiroNome} {UltimoNome}";
        }
    }
}