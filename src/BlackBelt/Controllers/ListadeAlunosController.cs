using Microsoft.AspNetCore.Mvc;

namespace BlackBelt.Controllers
{
    public class ListadeAlunosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}