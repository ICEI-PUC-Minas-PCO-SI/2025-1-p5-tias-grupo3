using Microsoft.AspNetCore.Mvc;

namespace BlackBelt.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}