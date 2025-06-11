using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Repositories
{
    // Revisar código para implementar tratamento de exceção
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;
        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> BuscarInstrutores()
        {
            return _context.Usuarios
                .Where(u => u.Tipo_Usuario == "Instrutor")
                .ToList();
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

        public Usuario BuscarUsuario(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                //Revisar este trecho, pois é um crime retornar null
                return null;
            }
            
        }

        public Usuario BuscarUsuarioLogin(string cpf, string senha)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Cpf == cpf);
            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                //Revisar este trecho, pois é um crime retornar null
                return null;
            }

        }

        public Usuario CadastrarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public void EditarUsuario(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void ExcluirUsuario(int id)
        {
            var usuario = BuscarUsuario(id);
            if(usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}
