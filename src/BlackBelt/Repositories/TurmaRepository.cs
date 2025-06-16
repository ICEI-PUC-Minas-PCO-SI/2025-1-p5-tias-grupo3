using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly AppDbContext _context;
        public TurmaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Turma> BuscarTodasTurmas()
        {
            return _context.Turmas
                .Select(t => new Turma
                {
                    Id = t.Id,
                    Nome = t.Nome,
                    Horario = t.Horario,
                    Status = t.Status,
                    Dt_Cadastro = t.Dt_Cadastro,
                    Instrutor = t.Instrutor,
                });
        }

        public Turma BuscarTurma(int id)
        {
            var turma = _context.Turmas.FirstOrDefault(t => t.Id == id);
            return turma;
        }

        public Turma CadastrarTurma(Turma turma)
        {
            _context.Turmas.Add(turma);
            _context.SaveChanges();
            return turma;
        }

        public void EditarTurma(Turma turma)
        {
            _context.Turmas.Update(turma);
            _context.SaveChanges();
        }

        public void ExcluirTurma(int id)
        {
            var turma = BuscarTurma(id);
            if (turma != null)
            {
                _context.Turmas.Remove(turma);
                _context.SaveChanges();
            }
        }
    }
}
