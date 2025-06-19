using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        private readonly AppDbContext _context;
        public HabilidadeRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Habilidade> BuscarHabilidades(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastrarHabilidade(Habilidade habilidade)
        {
            _context.Habilidades.Add(habilidade);
            _context.SaveChanges();
        }

        public void EditarHabilidade(Habilidade habilidade)
        {
            throw new NotImplementedException();
        }

        public void ExcluirHabilidade(Habilidade habilidade)
        {
            throw new NotImplementedException();
        }
    }
}
