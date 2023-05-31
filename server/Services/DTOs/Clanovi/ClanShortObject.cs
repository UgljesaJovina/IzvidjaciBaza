using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class ClanShortObject
{
    public Guid Id { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public bool Aktivan { get; set; }

    public ClanShortObject(Guid id, string ime, string prezime, bool aktivan)
    {
        Id = id;
        Ime = ime;
        Prezime = prezime;
        Aktivan = aktivan;
    }

    public ClanShortObject(Clan c) : this(c.Id, c.Ime, c.Prezime, c.Aktivan) { }

    public ClanShortObject() { }

    public static ICollection<ClanShortObject> TransformList(ICollection<Clan> clanovi) {
        return clanovi.Select(clan => new ClanShortObject(clan)).ToList();
    }
}