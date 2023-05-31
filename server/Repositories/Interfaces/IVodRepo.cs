using Repositories.Models;

namespace Repositories.Interfaces;

public interface IVodRepo : IRepository<Vod>
{
    bool AddClan(Guid vodId, Guid clanId);
    ICollection<Clan> AddClanove(Guid vodId, ICollection<Guid> clanIds);
    bool RemoveClan(Guid vodId, Guid clanId);
}