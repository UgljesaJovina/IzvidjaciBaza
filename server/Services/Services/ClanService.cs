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

    public ClanListObject? Create(ClanCreation? clanCreation)
    {
        if (clanCreation is null) return null;
        
        Clan c = clanCreation.GetClan();
        clanRepo.Create(c);

        return new ClanListObject(c);
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

    public bool DeleteKazna(Guid kaznaId)
    {
        return clanRepo.DeleteKazna(kaznaId);
    }

    public ICollection<ClanListObject> GetActive()
    {
        return clanRepo.GetActive().Select(c => new ClanListObject(c)).ToList();
    }

    public ICollection<ClanListObject> GetAll()
    {
        return clanRepo.GetAll().Select(c => new ClanListObject(c)).ToList();
    }

    public DisplayClan? GetById(Guid id)
    {
        Clan? c = clanRepo.GetById(id);
        
        return c is null ? null : new DisplayClan(c);
    }

    public DisplayKazna? GetKaznaById(Guid kaznaId)
    {
        Kazna? k = clanRepo.GetKaznaById(kaznaId);

        return k is null ? null : new DisplayKazna(k);
    }

    public ICollection<KaznaShortObject>? GetKazne(Guid id)
    {
        return clanRepo.GetKazne(id)?.Select(k => new KaznaShortObject(k)).ToList();
    }

    public DisplayClan? Update(Guid id, DisplayClan? displayClan)
    {
        Clan? c = clanRepo.GetById(id);
        if (c is null || displayClan is null) return null;

        displayClan.UpdateClan(c);
        return displayClan;
    }

    public ICollection<PohvalaShortObject>? GetPohvale(Guid id)
    {
        return clanRepo.GetPohvale(id)?.Select(p => new PohvalaShortObject(p)).ToList();
    }

    public DisplayPohvala? GetPohvalaById(Guid pohvalaId)
    {
        throw new NotImplementedException();
    }

    public PohvalaShortObject? CreatePohvala(Guid clanId, PohvalaCreation? pohvalaCreation)
    {
        throw new NotImplementedException();
    }

    public bool DeletePohvala(Guid pohvalaId)
    {
        throw new NotImplementedException();
    }

    public ZnanjeShortObject? AddZnanje(Guid clanId, ZnanjeCreation? znanje)
    {
        throw new NotImplementedException();
    }

    public ZnanjeShortObject? GetMaxZnanje(Guid clanId)
    {
        throw new NotImplementedException();
    }

    public ICollection<ClanListObject> GetSameZnanje(ZnanjeCreation? znanje)
    {
        throw new NotImplementedException();
    }

    public bool RemoveZnanje(Guid clanId, Guid znanjeId)
    {
        throw new NotImplementedException();
    }

    public DisplayPosProg? CreateProgram(PosProgCreation? program)
    {
        throw new NotImplementedException();
    }

    public DisplayClanskiProgram? AddProgram(Guid clanId, PosProgCreation? program)
    {
        throw new NotImplementedException();
    }

    public bool RemoveProgram(Guid clanId, Guid? program)
    {
        throw new NotImplementedException();
    }

    public ICollection<ClanShortObject> GetSameProgram(Guid programId)
    {
        throw new NotImplementedException();
    }

    public CFuncShortObject? CreateFunkcija(OFuncShortObject? funkcija)
    {
        throw new NotImplementedException();
    }

    public ICollection<OFuncShortObject> GetOdredskeFunkcije()
    {
        throw new NotImplementedException();
    }

    public ICollection<ClanShortObject> GetSameFunkcija(Guid oFuncId)
    {
        throw new NotImplementedException();
    }

    public CFuncShortObject? AddFunkcija(Guid clanId, Guid funkcijaId)
    {
        throw new NotImplementedException();
    }

    public bool FunkcijaActiveStateChange(Guid funkcijaId, bool state)
    {
        throw new NotImplementedException();
    }

    public ICollection<CFuncShortObject>? GetFunkcije(Guid clanId)
    {
        throw new NotImplementedException();
    }

    public ClanarinaShortObject? AddClanarina(Guid clanId, ClanarinaCreation? clanarina)
    {
        throw new NotImplementedException();
    }

    public bool RemoveClanarina(Guid clanarinaId)
    {
        throw new NotImplementedException();
    }
}