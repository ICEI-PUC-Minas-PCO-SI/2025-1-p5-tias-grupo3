using BlackBelt.Models;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq.Expressions;

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

        //Esta é a tela do formulário para cadastrar
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult Cadastro()
        {
            ViewData["Instrutores"] = BuscarInstrutores();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult CadastrarTurma(Turma turma)
        {
            try
            {
                turma.Dt_Cadastro = DateTime.Today;
                turma.Status = 1;
                _turmaRepository.CadastrarTurma(turma);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErroCadastroTurma"] = "Não foi possível cadastrar turma. Tente Novamente mais tarde.";
                return RedirectToAction("Cadastro");
            }
        }

        //Esta é a tela do formulário para editar
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult Editar(int id)
        {
            ViewData["Instrutores"] = BuscarInstrutores();
            var turma = _turmaRepository.BuscarTurma(id);
            return View(turma);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult EditarTurma(Turma turma)
        {
            try
            {
                _turmaRepository.EditarTurma(turma);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErroEditarTurma"] = "Não foi possível editar turma. Tente Novamente mais tarde.";
                return RedirectToAction("Cadastro");
            }
        }

        //Esta é a tela para excluir
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public IActionResult ExcluirTurma(int id)
        {
            try
            {
                _turmaRepository.ExcluirTurma(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErroExcluirTurma"] = "Não foi possível excluir turma. Tente novamente mais tarde.";
                return RedirectToAction("Index");
            }
        }

        //Esta função apenas busca a lista de instrutores
        private IEnumerable<Usuario> BuscarInstrutores()
        {
            IEnumerable<Usuario> instrutores = _usuarioRepository.BuscarInstrutores();
            return instrutores;
        }
    }
}
