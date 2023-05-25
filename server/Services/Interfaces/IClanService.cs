using Repositories.Models;
using Repositories.Interfaces;
using Services.DTOs;

namespace Services.Interfaces;

public interface IClanService
{
    ICollection<ClanShortObject> GetAll();
    ICollection<ClanShortObject> GetActive();
    DisplayClan? GetById(Guid id);
    ClanShortObject? Create(ClanCreation? clanCreation);
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
    ICollection<ClanShortObject> GetSameZnanje(ZnanjeCreation? znanje);
    bool RemoveZnanje(Guid clanId, Guid znanjeId);

    // ===================== POSEBAN PROGRAM =====================

    DisplayPosProg? AddProgram(Guid clanId, PosProgCreation? program);
    bool RemoveProgram(Guid clanId, Guid? program);

    // ===================== ODREDSKE FUNKCIJE =====================
}
