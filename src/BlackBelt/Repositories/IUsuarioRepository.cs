using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public interface IUsuarioRepository
    {
        public IEnumerable<Usuario> BuscarTodosUsuarios();
        public Usuario CadastrarUsuario(Usuario usuario);
    }
}
