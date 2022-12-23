using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;

public class Clan
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [StringLength(20)]
    public string Ime { get; set; }

    [StringLength(20)]
    public string Prezime { get; set; }

    public Kategorija? _Kategorija;
    public DateTime DatumRodjenja { get; set; }
    public DateTime DatumUclanjenja { get; set; } = DateTime.Today;
    public DateTime? DatumDavanjaZaveta { get; set; }

    [StringLength(50)]
    public string? Adresa { get; set; }

    public Vod? Vod { get; set; }

    public virtual ICollection<Akcija> Akcije { get; set; } = new List<Akcija>();
    public virtual ICollection<Tecaj> Tecajevi { get; set; } = new List<Tecaj>();
    public virtual ICollection<OdredskaFunkcija> Funkcije { get; set; } = new List<OdredskaFunkcija>();
    public virtual ICollection<ClanZnanje> Znanja { get; set; } = new List<ClanZnanje>();
    public virtual ICollection<Kazna> Kazne { get; set; } = new List<Kazna>();
    public virtual ICollection<Pohvala> Pohvale { get; set; } = new List<Pohvala>();
    public virtual ICollection<PosebanProgram> PosebniProgrami { get; set; } = new List<PosebanProgram>();

    public Clan(string ime, string prezime, DateTime datumRodjenja, DateTime datumUclanjenja)
    {
        Ime = ime;
        Prezime = prezime;
        DatumRodjenja = datumRodjenja;
        DatumUclanjenja = datumUclanjenja;
    }
}