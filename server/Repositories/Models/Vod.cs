using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;

public class Vod
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [StringLength(30)]
    public string Naziv { get; set; }

    public Kategorija _Kategorija { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}