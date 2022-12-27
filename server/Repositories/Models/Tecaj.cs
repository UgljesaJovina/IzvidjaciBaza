using System.ComponentModel.DataAnnotations;

namespace Repositories.Models;

public class Tecaj
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string Naziv { get; set; }

    public string? Opis { get; set; }

    [StringLength(40)]
    public string? MestoOdrzavanja { get; set; }

    public virtual ICollection<Clan> Clanovi { get; set; } = new List<Clan>();
}