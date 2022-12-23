namespace Repositories.Models;

public class Pohvala
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DatumDobijanja { get; set; }
    public string? DodeljivacPohvale { get; set; }
    public string Opis { get; set; }
    public Clan _Clan { get; set; }
}