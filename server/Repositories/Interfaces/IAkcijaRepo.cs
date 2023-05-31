using Repositories.Models;

namespace Repositories.Interfaces;

public interface IAkcijaRepo : IRepository<Akcija>
{
    bool AddClan(Guid akcijaId, Guid clanId);
    ICollection<Clan> AddClanove(Guid akcijaId, ICollection<Guid> clanIds);
    bool RemoveClan(Guid akcijaId, Guid clanId);

    OblikAkcije? CreateOblikAkcije(OblikAkcije? oa);
    ICollection<OblikAkcije> GetOblikeAkcije();
    
    TipAkcije? CreateTipAkcije(TipAkcije? ta);
    ICollection<TipAkcije> GetTipoveAkcije();
}