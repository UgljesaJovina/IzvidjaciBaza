using Repositories.Interfaces;
using Repositories.Models;
using Repositories.Repositories;
using Services.DTOs;
using Services.Interfaces;

namespace Services.Services;

public class ClanService : IClanService
{
    IClanRepo clanRepo;

    public ClanService (IClanRepo _clanRepo) { clanRepo = _clanRepo; }

    public ClanShortObject? Create(ClanCreation? clanCreation)
    {
        if (clanCreation is null) return null;
        
        Clan c = clanCreation.GetClan();
        clanRepo.Create(c);

        return new ClanShortObject(c);
    }

    public KaznaShortObject? CreateKazna(Guid clanId, KaznaCreation? kaznaCreation)
    {
        if (kaznaCreation is null) return null; 

        Kazna k = kaznaCreation.GetKazna();
        Kazna? retKazna = clanRepo.CreateKazna(clanId, k);

        return retKazna is null ? null :  new KaznaShortObject(retKazna);
    }

    public bool Delete(Guid id)
    {
        return clanRepo.Delete(id);
    }

    public bool DeleteKazna(Guid clanId, Guid kaznaId)
    {
        return clanRepo.DeleteKazna(kaznaId);
    }

    public ICollection<ClanShortObject> GetActive()
    {
        return clanRepo.GetActive().Select(c => new ClanShortObject(c)).ToList();
    }

    public ICollection<ClanShortObject> GetAll()
    {
        return clanRepo.GetAll().Select(c => new ClanShortObject(c)).ToList();
    }

    public DisplayClan? GetById(Guid id)
    {
        Clan? c = clanRepo.GetById(id);
        
        return c is null ? null : new DisplayClan(c);
    }

    public DisplayKazna? GetKaznaById(Guid clanId, Guid kaznaId)
    {
        Kazna? k = clanRepo.GetKaznaById(kaznaId);

        return k is null ? null : new DisplayKazna(k);
    }

    public ICollection<DisplayKazna>? GetKazne(Guid id)
    {
        return clanRepo.GetKazne(id)?.Select(k => new DisplayKazna(k)).ToList();
    }

    public DisplayClan? Update(Guid id, DisplayClan? displayClan)
    {
        Clan? c = clanRepo.GetById(id);
        if (c is null || displayClan is null) return null;

        displayClan.UpdateClan(c);
        return displayClan;
    }
}