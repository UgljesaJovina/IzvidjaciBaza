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

    ClanZnanje? CreateZnanje(ClanZnanje? znanje);
    ClanZnanje? AddZnanje(Guid clanId, ClanZnanje? znanje);
    ClanZnanje? GetMaxZnanje(Guid clanId);
    bool RemoveZnanje(Guid clanId, Guid znanjeId);

    // ===================== POSEBAN PROGRAM =====================

    PosebanProgram? CreateProgram(PosebanProgram? program);
    PosebanProgram? AddProgram(Guid clanId, PosebanProgram? program);
    bool RemoveProgram(Guid clanId, Guid programId);

    // ===================== FUNKCIJE =====================

    ClanFunkcija? CreateFunkcija(ClanFunkcija? funkcija);
    ClanFunkcija? AddFunkcija(Guid clanId, ClanFunkcija? funkcija);
    bool FunkcijaActiveStateChange(Guid clanId, Guid funkcijaId, bool state);
    ICollection<ClanFunkcija> GetFunkcije(Guid clanId);
    bool RemoveFunkcija(Guid clanId, Guid funkcijaId);

    // ===================== AKCIJE =====================

    Akcija? AddAkcija(Guid clanId, Akcija? akcija);
    bool RemoveAkcija(Guid clanId, Akcija? akcija);

    // ===================== TECAJEVI =====================

    Tecaj? AddTecaj(Guid clanId, Tecaj? tecaj);
    bool RemoveTecaj(Guid clanId, Tecaj? tecaj);

    // ===================== CLANARINE =====================

    Clanarina? AddClanarina(Guid clanId, Clanarina? clanarina);
    bool RemoveClanarina(Guid clanarinaId);


}
