using Repositories.Models;
using Repositories.Interfaces;
using Services.DTOs;

namespace Services.Interfaces;

public interface IClanService
{
    ICollection<ClanShortObject> GetAll();
    ICollection<ClanShortObject> GetActive();
    DisplayClan? GetById(Guid id);
    ClanShortObject? Create(ClanCreation? clanCreation);
    DisplayClan? Update(Guid id, DisplayClan? displayClan);
    bool Delete(Guid id);
    ICollection<DisplayKazna>? GetKazne(Guid id);
    DisplayKazna? GetKaznaById(Guid clanId, Guid kaznaId);
    KaznaShortObject? CreateKazna(Guid clanId, KaznaCreation? kaznaCreation);
    bool DeleteKazna(Guid clanId, Guid kaznaId);
}
