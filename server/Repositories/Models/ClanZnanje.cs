using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Enums;

namespace Repositories.Models;

public class ClanZnanje
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public Znanje Znanje { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Broj { get; set; }

    public DateTime DatumDobijanja { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}