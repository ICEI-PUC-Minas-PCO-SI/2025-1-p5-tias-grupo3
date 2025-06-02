using BlackBelt.Models;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlackBelt.Controllers
{
    public class TurmasController : Controller
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        public TurmasController(ITurmaRepository turmaRepository, IUsuarioRepository usuarioRepository)
        {
            _turmaRepository = turmaRepository;
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult Index()
        {
            IEnumerable<Turma> turmas = _turmaRepository.BuscarTodasTurmas();
            return View(turmas);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Cadastro()
        {
            ViewData["Instrutores"] = BuscarInstrutores();
            return View();
        }

        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult Editar(int id)
        {
            ViewData["Instrutores"] = BuscarInstrutores();
            var turma = _turmaRepository.BuscarTurma(id);
            return View(turma);
        }

        public IActionResult Excluir(int id)
        {
            var turma = _turmaRepository.BuscarTurma(id);
            if (turma != null)
            {
                return View(turma);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult CadastrarTurma(Turma turma)
        {
            turma.Dt_Cadastro = DateTime.Today;
            turma.Status = 1;
            _turmaRepository.CadastrarTurma(turma);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult EditarTurma(Turma turma)
        {
            _turmaRepository.EditarTurma(turma);
            return RedirectToAction("Index");

        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult ExcluirTurma(int id)
        {
            _turmaRepository.ExcluirTurma(id);
            return RedirectToAction("Index");
        }

        public IEnumerable<Usuario> BuscarInstrutores()
        {
            IEnumerable<Usuario> instrutores = _usuarioRepository.BuscarInstrutores();
            return instrutores;
        }
    }
}
