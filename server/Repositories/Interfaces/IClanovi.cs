using Repositories.DTOs;

namespace Repositories.Interfaces;

public interface IClanovi
{
    public List<ClanListObject> GetClanovi();
    public ClanListObject? CreateClan(ClanCreation? clanCreation);
}