using Repositories.Models;
using Repositories.Interfaces;
using Repositories.DAL;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Repositories;

public class AkcijaRepo : Repository<Akcija>, IAkcijaRepo
{
    public AkcijaRepo(DataContext _ctx) : base(_ctx) {}

    public override Akcija? GetById(Guid id)
    {
        return table.Include(akcija => akcija.Clanovi).FirstOrDefault(akcija => akcija.Id == id);
    }

    public bool AddClan(Guid akcijaId, Guid clanId)
    {
        Akcija? a = table.Find(akcijaId);
        Clan? c = ctx.Clanovi.FirstOrDefault(clan => clan.Id == clanId);

        if (a is null || c is null) return false;

        a.Clanovi.Add(c);
        Save();
        
        return true;
    }

    public ICollection<Clan?>? AddClanove(Guid akcijaId, ICollection<Guid> clanIds) {
        List<Clan?> dodatiClanovi = new();
        Akcija? a = table.Include(akcija => akcija.Clanovi)
            .FirstOrDefault(akcija => akcija.Id == akcijaId);
        if (a is null) return null;

        foreach (var clanId in clanIds) {
            Clan? c = ctx.Clanovi.Find(clanId);
            if (c is null) {
                dodatiClanovi.Add(null);
                continue;
            } 
            dodatiClanovi.Add(c);
            a.Clanovi.Add(c);
        }

        Save();

        return dodatiClanovi;
    }

    public bool RemoveClan(Guid akcijaId, Guid clanId)
    {
        Akcija? a = table.Include(akcija => akcija.Clanovi).FirstOrDefault(akcija => akcija.Id == akcijaId);
        Clan? c = a?.Clanovi.FirstOrDefault(clan => clan.Id == clanId);

        if (a is null || c is null) return false;

        a.Clanovi.Remove(c);
        Save();

        return true;
    }

    public OblikAkcije? CreateOblikAkcije(OblikAkcije? oa)
    {
        if (oa is null) return null;

        ctx.ObliciAkcija.Add(oa);
        Save();
        return oa;
    }

    public ICollection<OblikAkcije> GetOblikeAkcije()
    {
        return ctx.ObliciAkcija.ToList();
    }

    public TipAkcije? CreateTipAkcije(TipAkcije? ta)
    {
        if (ta is null) return null;

        ctx.TipoviAkcija.Add(ta);
        Save();
        return ta;
    }

    public ICollection<TipAkcije> GetTipoveAkcije()
    {
        return ctx.TipoviAkcija.ToList();
    }
}