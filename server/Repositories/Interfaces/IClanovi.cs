using Repositories.DTOs;
using Repositories.Models;

namespace Repositories.Interfaces;

public interface IClanovi
{
    public List<ClanListObject> GetClanovi();
    public ClanListObject? CreateClan(ClanCreation? clanCreation);
    public DisplayClan? GetClan(Guid id);
    public bool DeleteClan(Guid id);
    public DisplayKazna? GetKazna(Guid KaznaId);
    public KaznaListObject? CreateKazna(Guid id, KaznaCreation? kazna);
    public KaznaListObject? DeleteKazna(Guid KaznaId);
}