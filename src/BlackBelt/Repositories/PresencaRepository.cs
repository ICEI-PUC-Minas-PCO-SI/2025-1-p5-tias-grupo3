using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public class PresencaRepository:IPresencaRepository
    {
        private readonly AppDbContext _context;

        public PresencaRepository(AppDbContext context)
        {
            _context = context;
        }   

        public void LancarPresenca(List<Presenca> presencas)
        {
            foreach(var presenca in presencas)
            {
                _context.Presencas.Add(presenca);
                Console.WriteLine($"Aluno: {presenca.Id_Aluno}, Turma: {presenca.Id_Turma}, Presente: {presenca.Presente}");
                _context.SaveChanges();
            }
        }
    }
}
