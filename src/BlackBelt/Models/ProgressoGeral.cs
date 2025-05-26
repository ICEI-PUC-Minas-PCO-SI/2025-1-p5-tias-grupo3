using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class ProgressoGeral
    {
        public int Id_Aluno { get; set; }
        public DateOnly Dt_Avaliacao { get; set; }
        public double DesempenhoMedio { get; set; }

        [ForeignKey("Id_Aluno")]
        public Aluno Aluno { get; set; }
    }
}
