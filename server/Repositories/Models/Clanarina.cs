using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

/// <summary>
/// Polja: Datum (date), GodinaClanarine (int), Iznos (int) i Clan
/// </summary>

public class Clanarina
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    public DateTime DatumPlacanja { get; set; }
    [Required]
    public int GodinaClanarine { get; set; }
    public int? Iznos { get; set; }
    [Required]
    public Clan Clan { get; set; }

    public Clanarina(DateTime datumPlacanja, int godinaClanarine, int? iznos)
    {
        DatumPlacanja = datumPlacanja;
        GodinaClanarine = godinaClanarine;
        Iznos = iznos;
    }

    public Clanarina() { }
}