using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public DateTime Dt_Aula { get; set; }
        public int Id_Turma { get; set; }

        [ForeignKey("Id_Turma")]
        public Turma Turma { get; set; }
    }
}
