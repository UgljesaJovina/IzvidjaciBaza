using Repositories.Models;
using Repositories.Interfaces;
using Repositories.DAL;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Repositories;

public class TecajRepo : Repository<Tecaj>, ITecajRepo
{
    public TecajRepo(DataContext _ctx) : base(_ctx) {}

    public override Tecaj? GetById(Guid id)
    {
        return table.Include(tecaj => tecaj.Clanovi).FirstOrDefault(tecaj => tecaj.Id == id);
    }

    public bool AddClan(Guid tecajId, Guid clanId)
    {
        Tecaj? t = table.Find(tecajId);
        Clan? c = ctx.Clanovi.FirstOrDefault(clan => clan.Id == clanId);

        if (t is null || c is null) return false;

        t.Clanovi.Add(c);
        Save();
        
        return true;
    }
    
    public ICollection<Clan?>? AddClanove(Guid tecajId, ICollection<Guid> clanIds)
    {
        List<Clan?> dodatiClanovi = new();
        Tecaj? t = table.Include(tecaj => tecaj.Clanovi)
            .FirstOrDefault(tecaj => tecaj.Id == tecajId);
        if (t is null) return null;

        foreach (var clanId in clanIds) {
            Clan? c = ctx.Clanovi.Find(clanId);
            if (c is null) {
                dodatiClanovi.Add(null);
                continue;
            } 
            dodatiClanovi.Add(c);
            t.Clanovi.Add(c);
        }

        Save();

        return dodatiClanovi;
    }

    public bool RemoveClan(Guid tecajId, Guid clanId)
    {
        Tecaj? t = table.Include(akcija => akcija.Clanovi).FirstOrDefault(akcija => akcija.Id == tecajId);
        Clan? c = t?.Clanovi.FirstOrDefault(clan => clan.Id == clanId);

        if (t is null || c is null) return false;

        t.Clanovi.Remove(c);
        Save();

        return true;
    }

}