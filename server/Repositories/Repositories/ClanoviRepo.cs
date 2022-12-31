using Microsoft.EntityFrameworkCore;
using Repositories.DAL;
using Repositories.DTOs;
using Repositories.Interfaces;
using Repositories.Models;

namespace Repositories.Repositories;

public class ClanoviRepo : IClanovi
{
    DataContext ctx;

    public ClanoviRepo(DataContext _ctx)
    {
        ctx = _ctx;
    }

    public List<ClanListObject> GetClanovi(){
        return ctx.Clanovi.OrderBy(c => c.Ime).ThenBy(c => c.Prezime).Select(c => new ClanListObject(c)).ToList();
    }

    public ClanListObject? CreateClan(ClanCreation? clanCreation){
        if (clanCreation is null) return null;
        Clan clan = clanCreation.GetClan();
    
        ctx.Clanovi.Add(clan);
        ctx.SaveChanges();
        return new ClanListObject(clan);
    }

    public DisplayClan? GetClan(Guid id)
    {
        Clan? clan = ctx.Clanovi.Include(c => c.Akcije)
                                .Include(c => c.Tecajevi)
                                .Include(c => c.PosebniProgrami)
                                .Include(c => c.Znanja)
                                .Include(c => c.Pohvale)
                                .Include(c => c.Kazne)
                                .Include(c => c.PlaceneClanarine)
                                .FirstOrDefault(c => c.Id == id);

        if (clan is null) return null;
        clan.Kazne.OrderByDescending(k => k.DatumDobijanja);
        return new DisplayClan(clan);
    }

    public bool DeleteClan(Guid id)
    {
        Clan? clan = ctx.Clanovi.Find(id);

        if (clan is null) return false;

        ctx.Clanovi.Remove(clan);
        ctx.SaveChanges();
        return true;
    }

    public DisplayKazna? GetKazna(Guid KaznaId)
    {
        Kazna? k = ctx.Kazne.Find(KaznaId);
        if (k is null) return null;
        
        return new DisplayKazna(k);
    }

    public KaznaListObject? CreateKazna(Guid id, KaznaCreation? kazna)
    {
        Clan? c = ctx.Clanovi.Find(id);
        if (c is null || kazna is null) return null;

        Kazna k = kazna.GetKazna();
        k.Clan = c;
        ctx.Kazne.Add(k);
        ctx.SaveChanges();
        return new KaznaListObject(k);
    }

    public KaznaListObject? DeleteKazna(Guid KaznaId)
    {
        Kazna? k = ctx.Kazne.FirstOrDefault(k => k.Id == KaznaId);
        if (k is null) return null;

        ctx.Kazne.Remove(k);
        ctx.SaveChanges();
        return new KaznaListObject(k);
    }
}