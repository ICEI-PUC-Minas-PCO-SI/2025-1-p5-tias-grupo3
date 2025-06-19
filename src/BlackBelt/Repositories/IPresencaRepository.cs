using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public interface IPresencaRepository
    {
        public void LancarPresenca(List<Presenca> presencas);
    }
}
