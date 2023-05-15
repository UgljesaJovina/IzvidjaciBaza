using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

// blagajnik, nacelnik, vodnik, predvodnik itd.



// UPDATEOVATI BAZU PODATAKA SA NOVIM IZMENAMA!!!!!!!!!!!!


public class OdredskaFunkcija
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(30)]
    public string Naziv { get; set; }
    public virtual ICollection<ClanFunkcija> FunkcijeClanova { get; set; } = new List<ClanFunkcija>();
}