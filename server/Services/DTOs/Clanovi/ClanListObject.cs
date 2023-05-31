using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class ClanListObject
{
    public Guid Id { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public string? Kategorija { get; set; }
    public VodShortObject? Vod { get; set; }
    public ICollection<CFuncShortObject> Funkcije { get; set; }
    public bool Aktivan { get; set; }

    public ClanListObject(Guid id, string ime, string prezime, DateTime datumRodjenja, string? kategorija,
        VodShortObject? vod, ICollection<CFuncShortObject> funkcije, bool aktivan)
    {
        Id = id;
        Ime = ime;
        Prezime = prezime;
        DatumRodjenja = datumRodjenja;
        Kategorija = kategorija;
        Vod = vod;
        Funkcije = funkcije;
        Aktivan = aktivan;
    }

    public ClanListObject(){}

    public ClanListObject(Clan clan) : this(clan.Id, clan.Ime, clan.Prezime, clan.DatumRodjenja, clan.Kategorija.ToString(), 
            VodShortObject.GetShortObject(clan.Vod), CFuncShortObject.TransformList(clan.Funkcije), clan.Aktivan) {}
}