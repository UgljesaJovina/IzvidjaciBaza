using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;

/// <summary>
/// Ovo su sva vestarstva i vestine koje neko moze da ima
/// <para>
/// TipPrograma enum: { Vestina, Vestarstvo, Specijalnost }
/// </para>
/// </summary>
public class PosebanProgram
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(75)]
    public string Naziv { get; set; }

    [Required]
    public TipPrograma Tip { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}