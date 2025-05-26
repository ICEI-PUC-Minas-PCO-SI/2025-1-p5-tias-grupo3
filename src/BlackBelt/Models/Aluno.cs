using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Telefone { get; set; }
        [DataType(DataType.Date)]
        public DateOnly Dt_Nascimento { get; set; }
        public int Id_Faixa { get; set; }
        public DateOnly Dt_Matricula { get; set; }

        [ForeignKey("Id_Faixa")]
        public Faixa Faixa { get; set; }
    }
}
