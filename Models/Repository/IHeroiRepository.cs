using SuperHerois.Models.ViewModels;

namespace SuperHerois.Models.Repository;

public interface IHeroiRepository
{
    public List<HeroiViewModel> ObterTodosHerois();
    public HeroiViewModel? ObterHeroi(int id);
    public void AdicionarHeroi(HeroiViewModel heroi);
    public void AtualizarHeroi(int id, HeroiViewModel heroi);
    public void DeletarHeroi(int id);
}

