using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Enums;

namespace Repositories.Models;

/// <summary>
/// Ovde su znanja poput let laste, drugi krin itd.
/// <para>
/// Znanje enum: { Let, Zvezda, Krin, Orao }
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
    public DateTime DatumDobijanja { get; set; }

    [NotMapped]
    public int ZnanjeValue { get { return ((int)Znanje * 10) + Broj; }}

    public ClanZnanje(Znanje znanje, int broj, DateTime datumDobijanja)
    {
        Znanje = znanje;
        Broj = broj;
        DatumDobijanja = datumDobijanja;
    }

    public static bool operator == (ClanZnanje cz1, ClanZnanje cz2) {
        if (cz1 is null && cz2 is null) return true;
        else if (cz1 is null || cz2 is null) return false;
        
        return cz1.Znanje == cz2.Znanje && cz1.Broj == cz2.Broj;
    }

    public static bool operator != (ClanZnanje? cz1, ClanZnanje? cz2) {
        if (cz1 is null && cz2 is null) return false;
        else if (cz1 is null || cz2 is null) return true;

        return cz1.Znanje != cz2.Znanje || cz1.Broj != cz2.Broj;
    }
}