using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;

public class Clan
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(30)]
    public string Ime { get; set; }

    [Required]
    [StringLength(20)]
    public string Prezime { get; set; }

    public Kategorija? Kategorija { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public DateTime DatumUclanjenja { get; set; }
    public DateTime? DatumObecanja { get; set; }
    public DateTime? DatumZaveta { get; set; }

    [StringLength(75)]
    public string? Adresa { get; set; }

    [StringLength(12)]
    public string? Telefon { get; set; }
    public string? Mail { get; set; }

    public Vod? Vod { get; set; }

    [StringLength(10)]
    public string? BrojKnjizice { get; set; }

    [StringLength(30)]
    public string? ImeRoditelja1 { get; set; }

    [StringLength(30)]
    public string? ImeRoditelja2 { get; set; }

    [StringLength(30)]
    public string? PrezimeRoditelja1 { get; set; }

    [StringLength(30)]
    public string? PrezimeRoditelja2 { get; set; }

    [StringLength(30)]
    public string? BrojTelefonaR1 { get; set; }

    [StringLength(30)]
    public string? BrojTelefonaR2 { get; set; }

    public string? MailR1 { get; set; }
    public string? MailR2 { get; set; }

    public bool Aktivan { get; set; } = true;

    public virtual ICollection<Akcija> Akcije { get; set; } = new List<Akcija>();
    public virtual ICollection<Tecaj> Tecajevi { get; set; } = new List<Tecaj>();
    public virtual ICollection<ClanFunkcija> Funkcije { get; set; } = new List<ClanFunkcija>();
    public virtual ICollection<ClanZnanje> Znanja { get; set; } = new List<ClanZnanje>();
    public virtual ICollection<Kazna> Kazne { get; set; } = new List<Kazna>();
    public virtual ICollection<Pohvala> Pohvale { get; set; } = new List<Pohvala>();
    public virtual ICollection<PosebanProgram> PosebniProgrami { get; set; } = new List<PosebanProgram>();
    public virtual ICollection<Clanarina> PlaceneClanarine { get; set; } = new List<Clanarina>();

    public Clan(string ime, string prezime, DateTime datumRodjenja, DateTime datumUclanjenja)
    {
        Ime = ime;
        Prezime = prezime;
        DatumRodjenja = datumRodjenja;
        DatumUclanjenja = datumUclanjenja;
    }

    public Clan(string ime, string prezime, Kategorija? kategorija, DateTime datumRodjenja, DateTime datumUclanjenja, DateTime? datumZaveta, string? adresa, string? telefon)
    {
        Ime = ime;
        Prezime = prezime;
        Kategorija = kategorija;
        DatumRodjenja = datumRodjenja;
        DatumUclanjenja = datumUclanjenja;
        DatumZaveta = datumZaveta;
        Adresa = adresa;
        Telefon = telefon;
    }

    public Clan(){}
}