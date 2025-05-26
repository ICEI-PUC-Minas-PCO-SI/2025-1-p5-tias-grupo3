using BlackBelt.Models;
using Microsoft.EntityFrameworkCore;

namespace BlackBelt.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos  { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Faixa> Faixas { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
        public DbSet<HabilidadeAluno> HabilidadesAluno  { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<ProgressoGeral> ProgressosGerais  { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProgressoGeral>().HasNoKey();
            modelBuilder.Entity<HabilidadeAluno>().HasNoKey();
        }
    }
}
