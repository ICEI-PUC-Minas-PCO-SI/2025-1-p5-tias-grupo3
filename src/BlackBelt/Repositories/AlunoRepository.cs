using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AppDbContext _context;
        public AlunoRepository(AppDbContext context)
        {
            _context = context;
        }
        public Aluno BuscarAluno(int id)
        {
            return _context.Alunos
                .SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<Aluno> BuscarAlunosPorTurma(int id_turma)
        {
            return _context.Alunos
                .Where(a => a.Id_Turma == id_turma)
                .ToList();
        }

        public IEnumerable<Aluno> BuscarTodosAlunos()
        {
            return _context.Alunos
                .Select(aluno => new Aluno
                {
                    Id = aluno.Id,
                    Nome = aluno.Nome,
                    Cpf = aluno.Cpf,
                    Email = aluno.Email,
                    Telefone = aluno.Telefone,
                    Dt_Nascimento = aluno.Dt_Nascimento,
                    Faixa = aluno.Faixa,
                    Turma = aluno.Turma,
                    Dt_Matricula = aluno.Dt_Matricula,
                });
        }

        public Aluno CadastrarAluno(Aluno aluno)
        {
            if (VerificarCpf(aluno.Cpf))
            {
                aluno.Dt_Matricula = DateTime.Now;
                _context.Alunos.Add(aluno);
                _context.SaveChanges();
                return aluno;
            }
            else
            {
                return null;
            }
        }

        public Aluno EditarAluno(Aluno aluno)
        {
            if (VerificarCpf(aluno.Cpf))
            {
                _context.Alunos.Update(aluno);
                _context.SaveChanges();
                return aluno;
            }
            else
            {
                return null;
            }
        }

        public void ExcluirAluno(int id)
        {
            var aluno = BuscarAluno(id);
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
        }

        private bool VerificarCpf(string cpf)
        {
            //Se ele retornar false não deixará cadastrar o Aluno
            if (_context.Alunos.SingleOrDefault(a => a.Cpf == cpf) != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
