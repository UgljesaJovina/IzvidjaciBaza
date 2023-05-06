using Repositories.DAL;
using Repositories.Interfaces;
using Repositories.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Repositories;

public class ClanRepository : Repository<Clan>, IClanRepo
{ 

    public ClanRepository(DataContext _ctx) : base(_ctx) {}

    public ICollection<Kazna>? GetKazne(Guid clanId)
    {
        Clan? c = table.Find(clanId);
        if (c is null) return null;

        table.Entry(c).Collection(c => c.Kazne).Load();

        ICollection<Kazna> kazne = c.Kazne;
        return kazne;
    }

    public ICollection<Clan> GetActive()
    {
        return table.Where(c => c.Aktivan).ToList();
    }

    public override Clan? GetById(Guid id)
    {
        Clan? c = table
            .Include(c => c.Akcije)
            .Include(c => c.Tecajevi)
            .Include(c => c.Akcije)
            .Include(c => c.Tecajevi)
            .Include(c => c.Funkcije)
            .Include(c => c.Znanja)
            .Include(c => c.Kazne)
            .Include(c => c.Pohvale)
            .Include(c => c.PosebniProgrami)
            .Include(c => c.PlaceneClanarine)
            .FirstOrDefault(c => c.Id == id);

        if (c is null) return null;

        return c;
    }

    public override bool Delete(Guid id)
    {
        Clan? clan = table.Find(id);

        if (clan is null) return false;

        clan.Aktivan = false;
        Save();
        return true;
    }

    public Kazna? CreateKazna(Guid clanId, Kazna? kazna)
    {
        Clan? c = table.Include(clan => clan.Kazne).FirstOrDefault(clan => clan.Id == clanId);
        if (c is null || kazna is null) return null;

        kazna.Clan = c;
        ctx.Kazne.Add(kazna);

        Save();
        return kazna;
    }

    public Kazna? GetKaznaById(Guid clanId, Guid kaznaId)
    {
        Clan? c = table.Include(c => c.Kazne).FirstOrDefault(c => c.Id == clanId);
        if (c is null) return null;

        return c.Kazne.FirstOrDefault(k => k.Id == kaznaId);
    }

    public bool DeleteKazna(Guid clanId, Guid kaznaId)
    {
        Clan? c = table.Include(c => c.Kazne).FirstOrDefault(c => c.Id == clanId);
        Kazna? k = c?.Kazne.FirstOrDefault(k => k.Id == kaznaId);
        if (c is null || k is null) return false;

        c.Kazne.Remove(k);

        Save();

        return true;
    }
}
