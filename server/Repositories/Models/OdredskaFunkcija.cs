using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

// blagajnik, nacelnik, vodnik predvodnik itd.
public class OdredskaFunkcija
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}