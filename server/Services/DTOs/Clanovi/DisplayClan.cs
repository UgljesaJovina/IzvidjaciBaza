using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class DisplayClan
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string? Kategorija { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public DateTime DatumUclanjenja { get; set; }
    public DateTime DatumObecanja { get; set; }
    public DateTime? DatumZaveta { get; set; }
    public string? Adresa { get; set; }
    public string? Telefon { get; set; }
    public VodShortObject? Vod { get; set; }
    public virtual ICollection<AkcijaShortObject> Akcije { get; set; }
    public virtual ICollection<TecajShortObject> Tecajevi { get; set; }
    public virtual ICollection<FuncShortObject> Funkcije { get; set; }
    public virtual ICollection<ZnanjeShortObject> Znanja { get; set; }
    public virtual ICollection<PohvalaShortObject> Pohvale { get; set; }
    public virtual ICollection<KaznaShortObject> Kazne { get; set; }
    public virtual ICollection<PosProgShortObject> PosebniProgrami { get; set; }
    public virtual ICollection<ClanarinaShortObject> PlaceneClanarine { get; set; }

    public DisplayClan(Clan clan)
    {
        Ime = clan.Ime;
        Prezime = clan.Prezime;
        Kategorija = clan.Kategorija.ToString();
        DatumRodjenja = clan.DatumRodjenja;
        DatumUclanjenja = clan.DatumUclanjenja;
        DatumObecanja = DatumUclanjenja;
        DatumZaveta = clan.DatumZaveta;
        Adresa = clan.Adresa;
        Telefon = clan.Telefon;
        Vod = VodShortObject.GetShortObject(clan.Vod);
        Akcije = AkcijaShortObject.TransformList(clan.Akcije);
        Tecajevi = TecajShortObject.TransformList(clan.Tecajevi);
        Funkcije = FuncShortObject.TransformList(clan.Funkcije);
        Znanja = ZnanjeShortObject.TransformList(clan.Znanja);
        Pohvale = PohvalaShortObject.TransformList(clan.Pohvale);
        Kazne = KaznaShortObject.TransformList(clan.Kazne);
        PosebniProgrami = PosProgShortObject.TransformList(clan.PosebniProgrami);
        PlaceneClanarine = ClanarinaShortObject.TransfromList(clan.PlaceneClanarine);
    }

    public void UpdateClan(Clan c) {
        c.Ime = Ime;
        c.Prezime = Prezime;
        if (Enum.TryParse(Kategorija, out Repositories.Enums.Kategorija k)) c.Kategorija = k;
        c.DatumRodjenja = DatumRodjenja;
        c.DatumUclanjenja = DatumUclanjenja;
        c.DatumObecanja = DatumObecanja;
        c.DatumZaveta = DatumZaveta;
        c.Adresa = Adresa;
        c.Telefon = Telefon;
    }
}