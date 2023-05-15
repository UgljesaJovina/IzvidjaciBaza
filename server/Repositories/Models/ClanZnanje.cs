using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Enums;

namespace Repositories.Models;

/// <summary>
/// Ovde su znanja poput let laste, drugi krin itd.
/// <para>
/// Znanje enum: { Nema, Let, Zvezda, Krin, Orao }
/// </para>
/// <para>
/// Broj: let 1, zvezda 3, itd.
/// </para>
/// </summary>
public class ClanZnanje
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    public Znanje Znanje { get; set; }
    [Required]
    public int Broj { get; set; }
    public DateTime? DatumDobijanja { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}