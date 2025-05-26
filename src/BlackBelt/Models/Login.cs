using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Login
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        [Required(ErrorMessage = "Digite o cpf")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string Perfil { get; set; }
        public DateTime Dt_Login { get; set; } = DateTime.Now;
        public string Host { get; set; }

        [ForeignKey("Id_Usuario")]
        public Usuario Usuario { get; set; }
    }
}
