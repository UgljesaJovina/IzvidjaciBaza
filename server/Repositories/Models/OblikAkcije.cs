using System.ComponentModel.DataAnnotations;

namespace Repositories.Models;

/// <summary>
/// zimovanje, tabor, smotra itd.
/// </summary>
public class OblikAkcije
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Naziv { get; set; }

    public virtual ICollection<Akcija> Akcije { get; set; } = new List<Akcija>();
}