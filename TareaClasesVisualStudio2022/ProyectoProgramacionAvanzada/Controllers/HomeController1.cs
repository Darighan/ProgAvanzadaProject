using Microsoft.AspNetCore.Mvc;

namespace ProyectoProgramacionAvanzada.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
