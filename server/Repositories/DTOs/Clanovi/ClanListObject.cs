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
    public VodShortObject? Vod { get; set; }
    public ICollection<FuncShortObject> Funkcije { get; set; }

    public ClanListObject(Guid id, string ime, string prezime, DateTime datumRodjenja, string? kategorija,
        VodShortObject? vod, ICollection<FuncShortObject> funkcije)
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

    public ClanListObject(Clan clan) : this(clan.Id, clan.Ime, clan.Prezime, clan.DatumRodjenja, clan.Kategorija.ToString(), 
            VodShortObject.GetShortObject(clan.Vod), FuncShortObject.TransformList(clan.Funkcije)) {}
}