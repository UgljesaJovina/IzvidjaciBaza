using System.ComponentModel.DataAnnotations;

namespace Repositories.Models;

public class Akcija
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [StringLength(75)]
    public string Naziv { get; set; }

    public DateTime DatumPocetka { get; set; }
    public DateTime? DatumKraja { get; set; }

    [StringLength(40)]
    public string MestoOdrzavanja { get; set; }

    public TipAkcije? Tip { get; set; }
    public OblikAkcije? Oblik { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}