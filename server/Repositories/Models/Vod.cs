using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;

public class Vod
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(30)]
    public string Naziv { get; set; }

    [Required]
    public Kategorija Kategorija { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}