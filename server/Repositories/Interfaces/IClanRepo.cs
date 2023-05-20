using Repositories.Models;

namespace Repositories.Interfaces;

public interface IClanRepo : IRepository<Clan>
{
    ICollection<Kazna>? GetKazne(Guid clanId);
    ICollection<Clan> GetActive();

    // ===================== KAZNE =====================

    Kazna? CreateKazna(Guid clanId, Kazna? kazna);
    Kazna? GetKaznaById(Guid kaznaId);
    bool DeleteKazna(Guid kaznaId);

    // ===================== POHVALE =====================

    Pohvala? CreatePohvala(Guid clanId, Pohvala? pohvala);
    Pohvala? GetPohvalaById(Guid pohvalaId);
    bool DeletePohvala(Guid pohvalaId);

    // ===================== ZNANJA =====================

    ClanZnanje? GetZnanje(Guid id);
    ClanZnanje? CreateZnanje(ClanZnanje? znanje);
    ClanZnanje? AddZnanje(Guid clanId, ClanZnanje? znanje);
    ClanZnanje? GetMaxZnanje(Guid clanId);
    bool RemoveZnanje(Guid clanId, Guid znanjeId);

    // ===================== POSEBAN PROGRAM =====================

    PosebanProgram? CreateProgram(PosebanProgram? program);
    PosebanProgram? AddProgram(Guid clanId, PosebanProgram? program);
    bool RemoveProgram(Guid clanId, Guid programId);

    // ===================== ODREDSKE FUNKCIJE =====================

    OdredskaFunkcija? CreateFunkcija(OdredskaFunkcija? funkcija);
    ICollection<OdredskaFunkcija> GetOdredskeFunkcije();
    OdredskaFunkcija? GetOdredskaFunkcija(Guid id);

    // ===================== CLANSKE FUNKCIJE =====================

    ClanFunkcija? AddFunkcija(Guid clanId, OdredskaFunkcija? funkcija);
    bool FunkcijaActiveStateChange(Guid funkcijaId, bool state);
    ICollection<ClanFunkcija>? GetFunkcije(Guid clanId);

    // ===================== AKCIJE =====================

    Akcija? AddAkcija(Guid clanId, Guid akcijaId);
    bool RemoveAkcija(Guid clanId, Guid akcijaId);

    // ===================== TECAJEVI =====================

    Tecaj? AddTecaj(Guid clanId, Guid tecajId);
    bool RemoveTecaj(Guid clanId, Guid tecajId);

    // ===================== CLANARINE =====================

    Clanarina? AddClanarina(Guid clanId, Clanarina? clanarina);
    bool RemoveClanarina(Guid clanarinaId);


}
