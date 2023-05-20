using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

/// <summary>
/// Polja: Datum (date), GodinaClanarine (int), Iznos (int) i Clan
/// </summary>

public class Clanarina
{
    public Guid Id { get; set; }
    [Required]
    public DateTime DatumPlacanja { get; set; }
    [Required]
    public int GodinaClanarine { get; set; }
    public int? Iznos { get; set; }
    [Required]
    public Clan Clan { get; set; }
}