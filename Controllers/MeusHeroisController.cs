using Microsoft.AspNetCore.Mvc;
using SuperHerois.Models.Repository;
using SuperHerois.Models.ViewModels;

namespace SuperHerois.Controllers
{
    public class MeusHeroisController : Controller
    {
        private IHeroiRepository _heroiRepository;

        public MeusHeroisController(IHeroiRepository heroiRepository)
        {
            _heroiRepository = heroiRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detalhes(int? id)
        {
            if (id is null)
            {
                return BadRequest();
            }

            var heroi = _heroiRepository.ObterHeroi(id.GetValueOrDefault());
            if(heroi is null)
            {
                return NotFound();
            }

            return View(heroi);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar([Bind] HeroiViewModel heroi)
        {
            if(ModelState.IsValid)
            {
                _heroiRepository.AdicionarHeroi(heroi);
                return RedirectToAction("Detalhes", new { Id = heroi.Id });
            }

            return View(heroi);
        }
    }
}
