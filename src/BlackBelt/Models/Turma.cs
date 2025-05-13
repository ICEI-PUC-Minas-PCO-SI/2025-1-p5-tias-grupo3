namespace BalckBelt.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_Instrutor { get; set; }
        public TimeOnly Horario { get; set; }
        public int Status { get; set; }

    }
}
