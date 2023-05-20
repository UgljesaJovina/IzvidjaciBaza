using Repositories.Models;

namespace Repositories.Interfaces;

public interface IVodRepo : IRepository<Vod>
{
    bool AddClan(Guid vodId, Guid clanId);
    bool RemoveClan(Guid vodId, Guid clanId);
}