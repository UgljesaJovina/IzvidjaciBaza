using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

// odredska, nacionalna, medjunarodna itd.
public class TipAkcije
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [StringLength(25)]
    public string Naziv { get; set; } 

    public virtual ICollection<Akcija> Akcije { get; set; } = new List<Akcija>();
}