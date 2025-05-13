namespace BalckBelt.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public int Id_Turma { get; set; }
        public int Id_Aluno { get; set; }
        public DateOnly Dt_Aula { get; set; }
        public int Presenca { get; set; }

    }
}
