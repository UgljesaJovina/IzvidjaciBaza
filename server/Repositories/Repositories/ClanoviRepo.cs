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
        return ctx.Clanovi.OrderBy(c => c.Ime).ThenBy(c => c.Prezime).Select(c => ClanListObject.GetObject(c)).ToList();
    }

    public ClanListObject? CreateClan(ClanCreation? clanCreation){
        if (clanCreation is null) return null;
        Clan clan = clanCreation.GetClan();
    
        ctx.Clanovi.Add(clan);
        ctx.SaveChanges();
        return ClanListObject.GetObject(clan);
    }

    public DisplayClan? GetClan(Guid id)
    {
        Clan? clan = ctx.Clanovi.Find(id);
        if (clan is null) return null;
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
}