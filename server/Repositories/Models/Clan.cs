using System.ComponentModel.DataAnnotations;

namespace Repositories.Models;

public class Clan
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [StringLength(20)]
    public string Ime { get; set; }

    [StringLength(20)]
    public string Prezime { get; set; }

    public DateTime DatumRodjenja { get; set; }
    public DateTime DatumUclanjenja { get; set; }
    public DateTime DatumDavanjaZaveta { get; set; }
    public string Adresa { get; set; }
    public Vod Vod { get; set; }
    public virtual ICollection<OdredskaFunkcija> Funkcija { get; set; } = new List<OdredskaFunkcija>();
    public virtual ICollection<ClanZnanje> Znanja { get; set; } = new LinkedList<ClanZnanje>();
}