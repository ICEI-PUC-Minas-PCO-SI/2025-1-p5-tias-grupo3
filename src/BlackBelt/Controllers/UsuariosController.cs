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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Excluir()
        {
            return View();
        }

        public IActionResult CadastrarUsuario()
        {
            return RedirectToAction("Index");
        }

        public IActionResult EditarUsuario()
        {
            return RedirectToAction("Index");
        }

        public IActionResult ExcluirUsuario()
        {
            return RedirectToAction("Index");
        }
    }
}
