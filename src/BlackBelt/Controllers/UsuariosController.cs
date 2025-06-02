using BlackBelt.Models;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlackBelt.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult Index()
        {
            IEnumerable<Usuario> usuarios = _usuarioRepository.BuscarTodosUsuarios();
            return View(usuarios);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult Editar(int id)
        {
            var usuario = _usuarioRepository.BuscarUsuario(id);
            return View(usuario);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Excluir(int id)
        {
            var usuario = _usuarioRepository.BuscarUsuario(id);
            if (usuario != null)
            {
                return View(usuario);
            }
            else
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            usuario.SenhaHash = CriptografiaSenha.SenhaHash(usuario.Senha);
            usuario.Senha = null;
            _usuarioRepository.CadastrarUsuario(usuario);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin,Auxiliar")]
        [HttpPost]
        public IActionResult EditarUsuario(Usuario usuario)
        {
            _usuarioRepository.EditarUsuario(usuario);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult ExcluirUsuario(int id)
        {
            _usuarioRepository.ExcluirUsuario(id);
            return RedirectToAction("Index");
        }
    }
}
