namespace BalckBelt.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly Dt_Nascimento { get; set; }
        public int TipoUsuario { get; set; }
    }
}
