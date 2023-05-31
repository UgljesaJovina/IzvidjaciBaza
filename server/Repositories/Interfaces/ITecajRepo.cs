using Repositories.Models;

namespace Repositories.Interfaces;

public interface ITecajRepo : IRepository<Tecaj>
{
    bool AddClan(Guid tecajId, Guid clanId);
    ICollection<Clan> AddClanove(Guid tecajId, ICollection<Guid> clanIds);
    bool RemoveClan(Guid tecajId, Guid clanId);
}