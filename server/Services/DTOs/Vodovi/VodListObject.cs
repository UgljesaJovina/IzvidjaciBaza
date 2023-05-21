using Repositories.Models;

namespace Services.DTOs;

public class VodListObject
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }
    public string Kategorija { get; set; }
    public int BrojClanova { get; set; }

    public VodListObject(Guid id, string naziv, string kategorija, int brojClanova)
    {
        Id = id;
        Naziv = naziv;
        Kategorija = kategorija;
        BrojClanova = brojClanova;
    }

    public VodListObject(Vod vod) :this(vod.Id, vod.Naziv, vod.Kategorija.ToString(), vod.Clanovi.Count) { }
}