using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

// blagajnik, nacelnik, vodnik predvodnik itd.
public class OdredskaFunkcija
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(30)]
    public string Naziv { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}