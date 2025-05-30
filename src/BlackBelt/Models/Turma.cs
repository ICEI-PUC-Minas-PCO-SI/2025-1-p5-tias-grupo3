﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Id_Instrutor { get; set; }
        public TimeOnly Horario { get; set; }
        public int Status { get; set; }

        [ForeignKey("Id_Usuario")]
        public Usuario Instrutor { get; set; }
    }
}
