using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;


// Ovo su sva vestarstva i vestine koje neko moze da ima
public class PosebanProgram
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [StringLength(75)]
    public string Naziv { get; set; }

    public TipPrograma Tip { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}