using Repositories.Models;

namespace Repositories.Interfaces;

public interface ITecajRepo : IRepository<Tecaj>
{
    bool AddClan(Guid tecajId, Guid clanId);
    bool RemoveClan(Guid tecajId, Guid clanId);
}