using BlackBelt.Models;
using BlackBelt.Repositories;
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
        public IActionResult Index()
        {
            IEnumerable<Usuario> usuarios = _usuarioRepository.BuscarTodosUsuarios();
            return View(usuarios);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            var usuario = _usuarioRepository.BuscarUsuario(id);
            return View(usuario);
        }
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

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            _usuarioRepository.CadastrarUsuario(usuario);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuario usuario)
        {
            _usuarioRepository.EditarUsuario(usuario);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ExcluirUsuario(int id)
        {
            _usuarioRepository.ExcluirUsuario(id);
            return RedirectToAction("Index");
        }
    }
}
