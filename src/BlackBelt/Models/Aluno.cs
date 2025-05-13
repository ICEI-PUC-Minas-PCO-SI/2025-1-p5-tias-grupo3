namespace BalckBelt.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly Dt_Nascimento { get; set; }
        public int Nivel_Faixa { get; set; }
        public DateOnly Dt_Matricula { get; set; }

    }
}
