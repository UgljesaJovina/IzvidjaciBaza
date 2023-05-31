using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

/// <summary>
/// blagajnik, nacelnik, vodnik, predvodnik itd.
/// </summary>

public class OdredskaFunkcija
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(30)]
    public string Naziv { get; set; }
    public virtual ICollection<ClanFunkcija> ClanskeFunkcije { get; set; } = new List<ClanFunkcija>();
}