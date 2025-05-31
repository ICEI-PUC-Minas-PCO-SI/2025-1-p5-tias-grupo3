using BlackBelt.Models;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlackBelt.Controllers
{
    public class TurmasController:Controller
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        public TurmasController(ITurmaRepository turmaRepository, IUsuarioRepository usuarioRepository)
        {
            _turmaRepository = turmaRepository;
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Turma> turmas = _turmaRepository.BuscarTodasTurmas();
            return View(turmas);
        }

        public IActionResult Cadastro()
        {
            ViewData["Instrutores"] = BuscarInstrutores();
            return View();
        }
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
        public IActionResult CadastrarTurma(Turma turma)
        {
            turma.Dt_Cadastro = DateTime.Today;
            turma.Status = 1;
            _turmaRepository.CadastrarTurma(turma);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditarTurma(Turma turma)
        {
            _turmaRepository.EditarTurma(turma);
            return RedirectToAction("Index");
        }

        [HttpPost]
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
