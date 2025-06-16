using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Presenca
    {
        public int Id_Aula { get; set; }
        public int Id_Aluno { get; set; }

        //Se o status for 1 o aluno esteve presente se for 0 ele faltou
        public int Status { get; set; }
        [ForeignKey("Id_Aula")]
        public Aula Aula { get; set; }

        [ForeignKey("Id_Aluno")]
        public Aluno Aluno { get; set; }
        
    }
}
