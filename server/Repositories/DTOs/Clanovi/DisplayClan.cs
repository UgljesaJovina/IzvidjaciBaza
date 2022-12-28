using Repositories.Enums;
using Repositories.Models;

namespace Repositories.DTOs;

public class DisplayClan
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string? Kategorija { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public DateTime DatumUclanjenja { get; set; }
    public DateTime? DatumZaveta { get; set; }
    public string? Adresa { get; set; }
    public string? Telefon { get; set; }
    public Vod? Vod { get; set; }
    public virtual ICollection<AkcijaShortObject> Akcije { get; set; }
    public virtual ICollection<Tecaj> Tecajevi { get; set; }
    public virtual ICollection<OdredskaFunkcija> Funkcije { get; set; }
    public virtual ICollection<ClanZnanje> Znanja { get; set; }
    public virtual ICollection<Pohvala> Pohvale { get; set; }
    public virtual ICollection<Kazna> Kazne { get; set; }
    public virtual ICollection<PosebanProgram> PosebniProgrami { get; set; }
    public virtual ICollection<Clanarina> PlaceneClanarine { get; set; }

    public DisplayClan(Clan clan)
    {
        Ime = clan.Ime;
        Prezime = clan.Prezime;
        Kategorija = clan.Kategorija.ToString();
        DatumRodjenja = clan.DatumRodjenja;
        DatumUclanjenja = clan.DatumUclanjenja;
        DatumZaveta = clan.DatumZaveta;
        Adresa = clan.Adresa;
        Vod = clan.Vod;
        Telefon = clan.Telefon;
        Akcije = AkcijaShortObject.TransformList(clan.Akcije);
        Tecajevi = clan.Tecajevi;
        Funkcije = clan.Funkcije;
        Znanja = clan.Znanja;
        Pohvale = clan.Pohvale;
        Kazne = clan.Kazne;
        PosebniProgrami = clan.PosebniProgrami;
        PlaceneClanarine = clan.PlaceneClanarine;
    }

    public static DisplayClan GetDisplayClan (Clan clan) {
        return new DisplayClan(clan);
    }
}