using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Enums;

namespace Repositories.Models;

// Ovde su znanja poput let laste, drugi krin itd.
public class ClanZnanje
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Znanje Znanje { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Broj { get; set; }

    public DateTime? DatumDobijanja { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}