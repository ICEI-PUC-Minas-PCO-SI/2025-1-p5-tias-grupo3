using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public interface IUsuarioRepository
    {
        public IEnumerable<Usuario> BuscarTodosUsuarios();
        public IEnumerable<Usuario> BuscarInstrutores();
        public Usuario CadastrarUsuario(Usuario usuario);
        public void ExcluirUsuario(int id);
        public Usuario BuscarUsuario(int id);
        public void EditarUsuario(Usuario usuario);
    }
}
