namespace Repositories.Models;


public class ClanFunkcija
{
    public Guid Id { get; set; }
    public bool TrenutnoAktivna { get; set; }
    public OdredskaFunkcija Funkcija { get; set; }
    public Clan Clan { get; set; }
}