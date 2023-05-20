using Repositories.Models;

namespace Repositories.Interfaces;

public interface IAkcijaRepo : IRepository<Akcija>
{
    bool AddClan(Guid akcijaId, Guid clanId);
    bool RemoveClan(Guid akcijaId, Guid clanId);
}