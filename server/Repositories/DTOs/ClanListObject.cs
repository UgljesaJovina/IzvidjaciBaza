using Repositories.Models;

namespace Repositories.DTOs;

public class ClanListObject
{
    public Guid Id { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }

    public ClanListObject(Guid id, string ime, string prezime)
    {
        Id = id;
        Ime = ime;
        Prezime = prezime;
    }

    public ClanListObject(){}

    public static ClanListObject GetObject(Clan clan){
        return new ClanListObject(clan.Id, clan.Ime, clan.Prezime);
    }
}