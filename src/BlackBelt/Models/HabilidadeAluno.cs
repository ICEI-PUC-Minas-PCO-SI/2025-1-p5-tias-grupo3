using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class HabilidadeAluno
    {
        public int Id_Aluno { get; set; }
        public int Id_Habilidade { get; set; }

        [ForeignKey("Id_Aluno")]
        public Aluno Aluno { get; set; }
        [ForeignKey("Id_Habilidade")]
        public Habilidade Habilidade { get; set; }
    }
}
