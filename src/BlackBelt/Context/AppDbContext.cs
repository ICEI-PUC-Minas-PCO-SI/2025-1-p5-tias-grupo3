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
        public DbSet<Login> Logins { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Presenca> Presencas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Presenca>()
                .HasNoKey()
                .ToTable("Presencas");
        }

    }
}
