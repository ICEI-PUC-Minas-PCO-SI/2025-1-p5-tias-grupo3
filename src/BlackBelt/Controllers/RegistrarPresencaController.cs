using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlackBelt.Controllers
{
    public class RegistrarPresencaController: Controller
    {
        private readonly ITurmaRepository _turmaRepository;
        private readonly IAlunoRepository _alunoRepository;
        public RegistrarPresencaController(ITurmaRepository turmaRepository,IAlunoRepository alunoRepository)
        {
            _turmaRepository = turmaRepository;
            _alunoRepository = alunoRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult Index()
        {
            var turmas = _turmaRepository.BuscarTodasTurmas();
            return View(turmas);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Instrutor")]
        public IActionResult LancarAula(int id_turma) //no momento preciso descobrir por que a rota está trazendo o id 0
        {
            var alunos = _alunoRepository.BuscarAlunosPorTurma(id_turma);
            return View(alunos);
        }


    }
}
