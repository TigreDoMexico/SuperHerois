using Microsoft.AspNetCore.Mvc;

namespace SuperHerois.Controllers
{
    public class MeusHeroisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
