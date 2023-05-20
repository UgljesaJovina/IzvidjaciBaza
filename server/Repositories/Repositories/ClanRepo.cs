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
        Clan? c = table.Find(clanId);
        if (c is null || kazna is null) return null;

        kazna.Clan = c;
        ctx.Kazne.Add(kazna);

        Save();
        return kazna;
    }

    public Kazna? GetKaznaById(Guid kaznaId)
    {
        return ctx.Kazne.Find(kaznaId);
    }

    public bool DeleteKazna(Guid kaznaId)
    {
        Kazna? k = ctx.Kazne.Find(kaznaId);
        if (k is null) return false;

        ctx.Kazne.Remove(k);

        Save();

        return true;
    }

    public Pohvala? CreatePohvala(Guid clanId, Pohvala? pohvala)
    {
        Clan? c = table.Find(clanId);
        if (c is null || pohvala is null) return null;

        pohvala.Clan = c;
        ctx.Pohvale.Add(pohvala);

        Save();
        return pohvala;
    }

    public Pohvala? GetPohvalaById(Guid pohvalaId)
    {
        return ctx.Pohvale.Find(pohvalaId);
    }

    public bool DeletePohvala(Guid pohvalaId)
    {
        Pohvala? p = ctx.Pohvale.Find(pohvalaId);
        if (p is null) return false;

        ctx.Pohvale.Remove(p);
        Save();

        return true;
    }

    public ClanZnanje? GetZnanje(Guid id) 
    {
        return ctx.ClanoviZnanja.Find(id);
    }

    public ClanZnanje? CreateZnanje(ClanZnanje? znanje)
    {
        if (znanje is null) return null;
        ctx.ClanoviZnanja.Add(znanje);
        Save();

        return znanje;
    }

    public ClanZnanje? AddZnanje(Guid clanId, ClanZnanje? znanje)
    {
        Clan? c = table.Find(clanId);
        if (c is null || znanje is null) return null;

        znanje.Clanovi.Add(c);
        if (!ctx.ClanoviZnanja.Contains(znanje)) return null;
        Save();

        return znanje;
    }

    public ClanZnanje? GetMaxZnanje(Guid clanId)
    {
        Clan? c = table.Include(clan => clan.Znanja).FirstOrDefault(clan => clan.Id == clanId);
        if (c is null) return null;

        ClanZnanje? maxZnanje = null;
        foreach (var cz in c.Znanja)
        {
            if (cz.Znanje + cz.Broj > maxZnanje?.Broj + maxZnanje?.Znanje) maxZnanje = cz;
        }

        return maxZnanje;
    }

    public bool RemoveZnanje(Guid clanId, Guid znanjeId)
    {
        Clan? c = table.Include(clan => clan.Znanja).FirstOrDefault(clan => clan.Id == clanId);
        ClanZnanje? cz = c?.Znanja.FirstOrDefault(znanje => znanje.Id == znanjeId);
        if (c is null || cz is null) return false;

        c.Znanja.Remove(cz);
        Save();

        return true;
    }

    public PosebanProgram? CreateProgram(PosebanProgram? program)
    {
        if (program is null) return null;
        ctx.PosebniProgrami.Add(program);
        Save();

        return program;
    }

    public PosebanProgram? AddProgram(Guid clanId, PosebanProgram? program)
    {
        Clan? c = table.Find(clanId);
        if (c is null || program is null) return null;

        program.Clanovi.Add(c);
        if (!ctx.PosebniProgrami.Contains(program)) return null;
        Save();

        return program;
    }

    public bool RemoveProgram(Guid clanId, Guid programId)
    {
        Clan? c = table.Include(clan => clan.PosebniProgrami).FirstOrDefault(clan => clan.Id == clanId);
        PosebanProgram? pp = c?.PosebniProgrami.FirstOrDefault(program => program.Id == programId);
        if (c is null || pp is null) return false;

        c.PosebniProgrami.Remove(pp);
        Save();

        return true;
    }
    
    public OdredskaFunkcija? CreateFunkcija(OdredskaFunkcija? funkcija)
    {
        if (funkcija is null) return null;
        ctx.OdredskeFunkcije.Add(funkcija);

        Save();
        return funkcija;
    }

    public ICollection<OdredskaFunkcija> GetOdredskeFunkcije()
    {
        return ctx.OdredskeFunkcije.ToList();
    }

    public OdredskaFunkcija? GetOdredskaFunkcija(Guid id)
    {
        OdredskaFunkcija? of = ctx.OdredskeFunkcije.Find(id);
        return of;
    }

    public ClanFunkcija? AddFunkcija(Guid clanId, OdredskaFunkcija? funkcija)
    {
        Clan? c = table.Find(clanId);
        if (c is null || funkcija is null) return null;

        ClanFunkcija cf = new() { TrenutnoAktivna = true, Clan = c, Funkcija = funkcija };
        
        Save();
        return cf;
    }

    public bool FunkcijaActiveStateChange(Guid funkcijaId, bool state)
    {
        ClanFunkcija? cf = ctx.FunkcijeClanova.Find(funkcijaId);
        if (cf is null) return false;

        cf.TrenutnoAktivna = state;
        Save();
        return true;
    }

    public ICollection<ClanFunkcija>? GetFunkcije(Guid clanId)
    {
        Clan? c = table.Include(clan => clan.Funkcije).FirstOrDefault(clan => clan.Id == clanId);
        if (c is null) return null;

        return c.Funkcije;
    }

    public Akcija? AddAkcija(Guid clanId, Guid akcijaId)
    {
        Clan? c = table.Include(clan => clan.Akcije).FirstOrDefault(clan => clan.Id == clanId);
        Akcija? a = ctx.Akcije.Include(akcija => akcija.Clanovi).FirstOrDefault(akcija => akcija.Id == akcijaId);

        if (c is null || a is null) return null;

        c.Akcije.Add(a);
        Save();
        return a;
    }

    public bool RemoveAkcija(Guid clanId, Guid akcijaId)
    {
        Clan? c = table.Include(clan => clan.Akcije).FirstOrDefault(clan => clan.Id == clanId);
        Akcija? a = ctx.Akcije.Include(akcija => akcija.Clanovi).FirstOrDefault(akcija => akcija.Id == akcijaId);

        if (c is null || a is null) return false;

        c.Akcije.Remove(a);
        Save();
        return true;
    }

    public Tecaj? AddTecaj(Guid clanId, Guid tecajId)
    {
        Clan? c = table.Include(clan => clan.Tecajevi).FirstOrDefault(clan => clan.Id == clanId);
        Tecaj? t = ctx.Tecajevi.Include(tecaj => tecaj.Clanovi).FirstOrDefault(tecaj => tecaj.Id == tecajId);

        if (c is null || t is null) return null;

        c.Tecajevi.Add(t);
        Save();
        return t;
    }

    public bool RemoveTecaj(Guid clanId, Guid tecajId)
    {
        Clan? c = table.Include(clan => clan.Tecajevi).FirstOrDefault(clan => clan.Id == clanId);
        Tecaj? t = ctx.Tecajevi.Include(tecaj => tecaj.Clanovi).FirstOrDefault(tecaj => tecaj.Id == tecajId);

        if (c is null || t is null) return false;

        c.Tecajevi.Remove(t);
        Save();
        return true;
    }

    public Clanarina? AddClanarina(Guid clanId, Clanarina? clanarina)
    {
        Clan? c = table.Include(clan => clan.PlaceneClanarine).FirstOrDefault(clan => clan.Id == clanId);
        if (c is null || clanarina is null) return null;

        ctx.Clanarine.Add(clanarina);
        clanarina.Clan = c;
        Save();

        return clanarina;
    }

    public bool RemoveClanarina(Guid clanarinaId)
    {
        Clanarina? c = ctx.Clanarine.Find(clanarinaId);
        if (c is null) return false;

        ctx.Clanarine.Remove(c);
        Save();

        return true;
    }
}
