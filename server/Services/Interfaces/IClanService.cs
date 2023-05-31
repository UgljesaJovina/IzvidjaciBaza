using Repositories.Models;
using Repositories.Interfaces;
using Services.DTOs;

namespace Services.Interfaces;

public interface IClanService
{
    ICollection<ClanListObject> GetAll();
    ICollection<ClanListObject> GetActive();
    DisplayClan? GetById(Guid id);
    ClanListObject? Create(ClanCreation? clanCreation);
    DisplayClan? Update(Guid id, DisplayClan? displayClan);
    bool Delete(Guid id);

    // ===================== KAZNE =====================

    ICollection<KaznaShortObject>? GetKazne(Guid id);
    DisplayKazna? GetKaznaById(Guid kaznaId);
    KaznaShortObject? CreateKazna(Guid clanId, KaznaCreation? kaznaCreation);
    bool DeleteKazna(Guid kaznaId);

    // ===================== POHVALE =====================

    ICollection<PohvalaShortObject>? GetPohvale(Guid id);
    DisplayPohvala? GetPohvalaById(Guid pohvalaId);
    PohvalaShortObject? CreatePohvala(Guid clanId, PohvalaCreation? pohvalaCreation);
    bool DeletePohvala(Guid pohvalaId);

    // ===================== ZNANJA =====================

    ZnanjeShortObject? AddZnanje(Guid clanId, ZnanjeCreation? znanje);
    ZnanjeShortObject? GetMaxZnanje(Guid clanId);
    ICollection<ClanListObject> GetSameZnanje(ZnanjeCreation? znanje);
    bool RemoveZnanje(Guid clanId, Guid znanjeId);

    // ===================== POSEBAN PROGRAM =====================

    DisplayPosProg? CreateProgram(PosProgCreation? program);
    DisplayClanskiProgram? AddProgram(Guid clanId, PosProgCreation? program);
    bool RemoveProgram(Guid clanId, Guid? program);
    ICollection<ClanShortObject> GetSameProgram(Guid programId); 

    // ===================== ODREDSKE FUNKCIJE =====================

    CFuncShortObject? CreateFunkcija(OFuncShortObject? funkcija);
    ICollection<OFuncShortObject> GetOdredskeFunkcije();
    ICollection<ClanShortObject> GetSameFunkcija(Guid oFuncId);

    // ===================== CLANSKE FUNKCIJE =====================

    CFuncShortObject? AddFunkcija(Guid clanId, Guid funkcijaId);
    bool FunkcijaActiveStateChange(Guid funkcijaId, bool state);
    ICollection<CFuncShortObject>? GetFunkcije(Guid clanId);

    // ===================== CLANARINE =====================

    ClanarinaShortObject? AddClanarina(Guid clanId, ClanarinaCreation? clanarina);
    bool RemoveClanarina(Guid clanarinaId);
}
