using System.ComponentModel.DataAnnotations;

namespace Repositories.Models;

public class Kazna
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    public DateTime DatumDobijanja { get; set; }
    public DateTime? DatumIsteka { get; set; }
    public string? DodeljivacKazne { get; set; }
    [Required]
    public string Opis { get; set; }
    [Required]
    public Clan Clan { get; set; }
}