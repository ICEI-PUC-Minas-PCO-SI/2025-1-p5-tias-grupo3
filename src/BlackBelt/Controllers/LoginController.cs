using BlackBelt.Context;
using BlackBelt.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using System;
using BlackBelt.Repositories;

namespace BlackBelt.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILoginRepository _loginRepository;
        public LoginController(IUsuarioRepository usuarioRepository, ILoginRepository loginRepository)
        {
            _usuarioRepository = usuarioRepository;
            _loginRepository = loginRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(string cpf, string senha)
        {
            //Esta validação é somente para testes
            if(cpf == "1234" && senha == "1234")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //Esta é a validação oficial
                var usuario = _usuarioRepository.BuscarUsuarioLogin(cpf, senha);
                if (usuario != null && CriptografiaSenha.ValidarSenha(senha, usuario.SenhaHash))
                {
                    // Autenticar usuário
                    HttpContext.Session.SetString("UsuarioId", usuario.Id.ToString());
                    var perfil = _loginRepository.RegistrarLogin(usuario);
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Cpf ou senha inválidos");
            return View();
        }

    }

}
