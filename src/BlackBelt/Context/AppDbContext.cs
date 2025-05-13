using BalckBelt.Models;
using Microsoft.EntityFrameworkCore;

namespace BalckBelt.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Aula> Aulas  { get; set; }
        public DbSet<Faixa> Faixas  { get; set; }
        public DbSet<Habilidade> Habilidades  { get; set; }
        public DbSet<HabilidadeAluno> HabilidadesAluno { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<ProgressoGeral> ProgressoGeral { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
