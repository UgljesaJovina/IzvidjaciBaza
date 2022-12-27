using System.ComponentModel.DataAnnotations;

namespace Repositories.Models;

// zimovanje, tabor, smotra itd.
public class OblikAkcije
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Naziv { get; set; }

    public virtual ICollection<Akcija> Akcije { get; set; } = new List<Akcija>();
}