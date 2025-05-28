using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;
        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Usuario> BuscarTodosUsuarios()
        {
            return _context.Usuarios
                .Select(u => new Usuario
                {
                    Id = u.Id,
                    Nome = u.Nome,
                    Cpf = u.Cpf,
                    Telefone = u.Telefone,
                    Dt_Nascimento = u.Dt_Nascimento,
                    Tipo_Usuario = u.Tipo_Usuario
                });
        }

        public Usuario CadastrarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }
    }
}
