using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public int Id_Turma { get; set; }
        public int Id_Aluno { get; set; }
        public DateOnly Dt_Aula { get; set; }
        public int Presenca { get; set; }

        [ForeignKey("Id_Aluno")]
        public Aluno Aluno { get; set; }
        [ForeignKey("Id_Turma")]
        public Turma Turma { get; set; }
    }
}
