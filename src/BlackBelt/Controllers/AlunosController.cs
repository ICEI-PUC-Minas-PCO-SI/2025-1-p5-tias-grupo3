using BlackBelt.Models;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlackBelt.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly ITurmaRepository _turmaRepository;
        private readonly IHabilidadeRepository _habilidadeRepository;
        public AlunosController(IAlunoRepository alunoRepository, ITurmaRepository turmaRepository, IHabilidadeRepository habilidadeRepository)
        {
            _alunoRepository = alunoRepository;
            _turmaRepository = turmaRepository;
            _habilidadeRepository = habilidadeRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Auxiliar,Instrutor")]
        public IActionResult Index()
        {
            IEnumerable<Aluno> alunos = _alunoRepository.BuscarTodosAlunos();
            return View(alunos);
        }

        //Esta é a tela do formulário para cadastrar
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult Cadastro()
        {
            ViewData["Turmas"] = BuscarTurmas();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult CadastrarAluno(Aluno aluno)
        {
            try
            {
                if (_alunoRepository.CadastrarAluno(aluno) != null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErroCpfAluno"] = "Já existe aluno com este cpf";
                    return RedirectToAction("Cadastro");
                }

            }
            catch (Exception ex)
            {
                TempData["ErroCadastroAluno"] = "Não foi possível cadastrar aluno. Tente Novamente mais tarde.";
                return RedirectToAction("Cadastro");
            }
        }

        //Esta é a tela do formulário para editar
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult Editar(int id)
        {
            ViewData["Turmas"] = BuscarTurmas();
            var aluno = _alunoRepository.BuscarAluno(id);
            return View(aluno);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Auxiliar")]
        public IActionResult EditarAluno(Aluno aluno)
        {
            try
            {
                if (_alunoRepository.EditarAluno(aluno) == null)
                {
                    TempData["ErroCpfAluno"] = "Já existe aluno com este cpf";
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErroEditarAluno"] = "Não foi possível editar aluno. Tente Novamente mais tarde.";
                return RedirectToAction("Cadastro");
            }
        }

        //Esta é a tela para excluir
        [Authorize(Roles = "Admin")]
        public IActionResult Excluir(int id)
        {
            var aluno = _alunoRepository.BuscarAluno(id);
            if (aluno != null)
            {
                return View(aluno);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult ExcluirAluno(int id)
        {
            try
            {
                _alunoRepository.ExcluirAluno(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["ErroExcluirAluno"] = "Não foi possível excluir aluno. Tente Novamente mais tarde.";
                return RedirectToAction("Index");
            }
        }

        private IEnumerable<Turma> BuscarTurmas()
        {
            IEnumerable<Turma> turmas = _turmaRepository.BuscarTodasTurmas();
            return turmas;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult Perfil(int id)
        {
            var aluno = _alunoRepository.BuscarAluno(id);
            return View(aluno);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult CadastroHabilidade(int id)
        {
            Habilidade habilidade = new Habilidade
            {
                Id_Aluno = id
            };
            return View(habilidade);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult CadastrarHabilidade(Habilidade habilidade)
        {
            _habilidadeRepository.CadastrarHabilidade(habilidade);
            return RedirectToAction("Perfil",habilidade.Id_Aluno);
        }

    }
}
