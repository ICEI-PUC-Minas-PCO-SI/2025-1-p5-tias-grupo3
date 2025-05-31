using BlackBelt.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System;
using BlackBelt.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

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
        public async Task<IActionResult> Logar(string cpf, string senha) //Estou aqui tentando iniciar a tela de login pois deu erro
        {
            //Esta validação é somente para testes
            if (cpf == "1234" && senha == "1234")
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

                    // Cria as claims personalizadas
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,usuario.Nome),
                        new Claim(ClaimTypes.NameIdentifier,usuario.Id.ToString()),
                        new Claim(ClaimTypes.Role,usuario.Tipo_Usuario) // Exemplo de permissão personalizada
                    };

                    // Monta a identidade e o principal
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    // Efetua login com o cookie de autenticação
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        claimsPrincipal,
                        new AuthenticationProperties
                        {
                            IsPersistent = true, // Se quer manter a sessão após fechar o navegador
                            ExpiresUtc = DateTime.UtcNow.AddHours(2)
                        });


                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Cpf ou senha inválidos");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

    }

}
