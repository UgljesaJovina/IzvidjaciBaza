using Repositories.Models;

namespace Repositories.Interfaces;

public interface IClanRepo : IRepository<Clan>
{
    ICollection<Kazna>? GetKazne(Guid clanId);
    ICollection<Clan> GetActive();

    // ===================== KAZNE =====================

    Kazna? CreateKazna(Guid clanId, Kazna? kazna);
    Kazna? GetKaznaById(Guid clanId, Guid kaznaId);
    bool DeleteKazna(Guid clanId, Guid kaznaId);

    // ===================== POHVALE =====================

    // Pohvala? CreatePohvala(Guid clanId, Pohvala? pohvala);
    // Pohvala? GetPohvalaById(Guid clanId, Guid pohvalaId);
    // bool DeletePohvala(Guid clanId, Guid kaznaId);

    // // ===================== ZNANJA =====================

    // ClanZnanje? AddZnanje(Guid clanId, ClanZnanje? znanje);

    // ===================== POSEBAN PROGRAM =====================

    // ===================== FUNKCIJE =====================

    // ===================== AKCIJE =====================

    // ===================== TECAJEVI =====================

    // ===================== CLANARINE =====================


}
