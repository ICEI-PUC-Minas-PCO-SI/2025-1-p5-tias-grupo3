using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Usuario
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
        public string Tipo_Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [NotMapped]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string SenhaHash { get; set; }
    }
}
