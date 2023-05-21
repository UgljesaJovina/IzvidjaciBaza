using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

/// <summary>
/// odredska, nacionalna, medjunarodna itd.
/// </summary>
public class TipAkcije
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required]
    [StringLength(25)]
    public string Naziv { get; set; } 

    public virtual ICollection<Akcija> Akcije { get; set; } = new List<Akcija>();
}