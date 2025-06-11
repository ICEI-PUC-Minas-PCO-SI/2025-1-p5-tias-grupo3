using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(11)]
        [MinLength(11, ErrorMessage = "A quantidade mínima são 11 caracteres")]
        public string Cpf { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Telefone { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateOnly Dt_Nascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Tipo_Usuario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string SenhaHash { get; set; }
    }
}
