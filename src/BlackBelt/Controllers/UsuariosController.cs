using BlackBelt.Models;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlackBelt.Controllers
{
    public class UsuariosController:Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Usuario> usuarios = _usuarioRepository.BuscarTodosUsuarios();
            return View(usuarios);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            _usuarioRepository.CadastrarUsuario(usuario);
            return RedirectToAction("Index");
        }
    }
}
