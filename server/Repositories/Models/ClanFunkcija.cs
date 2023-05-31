namespace Repositories.Models;


/// <summary>
/// Odredske funkcije vezane za clana
/// <par>
/// Blagajnik, nacelnik, cetovodja, itd.
/// </par>
/// </summary>

public class ClanFunkcija
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool Aktivna { get; set; }
    public DateTime DatumDobijanja { get; set; }
    public OdredskaFunkcija Funkcija { get; set; }
    public Clan Clan { get; set; }
}