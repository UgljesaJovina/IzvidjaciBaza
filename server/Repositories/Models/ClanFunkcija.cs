namespace Repositories.Models;


/// <summary>
/// Odredske funkcije vezane za clana
/// <par>
/// Blagajnik, nacelnik, cetovodja, itd.
/// </par>
/// </summary>

public class ClanFunkcija
{
    public Guid Id { get; set; }
    public bool TrenutnoAktivna { get; set; }
    public OdredskaFunkcija Funkcija { get; set; }
    public Clan Clan { get; set; }
}