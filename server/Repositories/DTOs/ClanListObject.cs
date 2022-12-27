using Repositories.Enums;
using Repositories.Models;

namespace Repositories.DTOs;

public class ClanListObject
{
    public Guid Id { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public string? Kategorija { get; set; }
    public Vod? Vod { get; set; }
    public ICollection<OdredskaFunkcija> Funkcije { get; set; }

    public ClanListObject(Guid id, string ime, string prezime, DateTime datumRodjenja, string? kategorija,
        Vod? vod, ICollection<OdredskaFunkcija> funkcije)
    {
        Id = id;
        Ime = ime;
        Prezime = prezime;
        DatumRodjenja = datumRodjenja;
        Kategorija = kategorija;
        Vod = vod;
        Funkcije = funkcije;
    }

    public ClanListObject(){}

    public static ClanListObject GetObject(Clan clan){
        return new ClanListObject(clan.Id, clan.Ime, clan.Prezime, clan.DatumRodjenja, clan.Kategorija.ToString(), clan.Vod, clan.Funkcije);
    }
}