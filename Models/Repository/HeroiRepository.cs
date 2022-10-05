using SuperHerois.Models.ViewModels;

namespace SuperHerois.Models.Repository;

public class HeroiRepository : IHeroiRepository
{
    private static int VALOR = 1;
    private List<HeroiViewModel> herois = new List<HeroiViewModel>();

    public List<HeroiViewModel> ObterTodosHerois() =>
        new List<HeroiViewModel>(herois);
    
    public HeroiViewModel? ObterHeroi(int id) =>
        herois.Where(h => h.Id == id).FirstOrDefault();
    
    public void AdicionarHeroi(HeroiViewModel heroi)
    {
        heroi.Id = VALOR++;
        herois.Add(heroi);
    }

    public void AtualizarHeroi(int id, HeroiViewModel heroi)
    {
        var index = herois.FindIndex(h => heroi.Id == id);
        herois[index] = heroi;
    }

    public void DeletarHeroi(int id) =>    
        herois.RemoveAll(h => h.Id == id);
}
