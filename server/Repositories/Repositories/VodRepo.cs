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