using Repositories.Models;
using Repositories.Interfaces;
using Repositories.DAL;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Repositories;

public class VodRepo : Repository<Vod>, IVodRepo
{
    public VodRepo(DataContext _ctx) : base(_ctx) {}

    public override Vod? GetById(Guid id)
    {
        return table.Include(vod => vod.Clanovi).FirstOrDefault(vod => vod.Id == id);
    }

    public bool AddClan(Guid vodId, Guid clanId)
    {
        Vod? v = table.Find(vodId);
        Clan? c = ctx.Clanovi.FirstOrDefault(clan => clan.Id == clanId);

        if (v is null || c is null) return false;

        v.Clanovi.Add(c);
        Save();
        
        return true;
    }
    
    public ICollection<Clan?>? AddClanove(Guid vodId, ICollection<Guid> clanIds)
    {
        List<Clan?> dodatiClanovi = new();
        Vod? v = table.Include(vod => vod.Clanovi)
            .FirstOrDefault(vod => vod.Id == vodId);
        if (v is null) return null;

        foreach (var clanId in clanIds) {
            Clan? c = ctx.Clanovi.Find(clanId);
            if (c is null) {
                dodatiClanovi.Add(null);
                continue;
            } 
            dodatiClanovi.Add(c);
            v.Clanovi.Add(c);
        }

        Save();

        return dodatiClanovi;
    }

    public bool RemoveClan(Guid vodId, Guid clanId)
    {
        Vod? v = table.Include(akcija => akcija.Clanovi).FirstOrDefault(akcija => akcija.Id == vodId);
        Clan? c = v?.Clanovi.FirstOrDefault(clan => clan.Id == clanId);

        if (v is null || c is null) return false;

        v.Clanovi.Remove(c);
        Save();

        return true;
    }
}