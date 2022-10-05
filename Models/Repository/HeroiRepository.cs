using SuperHerois.Models.ViewModels;

namespace SuperHerois.Models.Repository;

public class HeroiRepository : IHeroiRepository
{
    private static int VALOR = 1;
    private List<HeroiViewModel> herois = new List<HeroiViewModel>();

    public List<HeroiViewModel> ObterTodosHerois()
    {
        return new List<HeroiViewModel>(herois);
    }

    public HeroiViewModel? ObterHeroi(int id)
    {
        return herois.Where(h => h.Id == id).FirstOrDefault();
    }

    public void AdicionarHeroi(HeroiViewModel heroi)
    {
        heroi.Id = VALOR++;
        herois.Add(heroi);
    }
}
