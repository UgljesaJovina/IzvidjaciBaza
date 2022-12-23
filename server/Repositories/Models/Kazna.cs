namespace Repositories.Models;

public class Kazna
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DatumDobijanja { get; set; }
    public DateTime DatumIsteka { get; set; }
    public string? DodeljivacKazne { get; set; }
    public string Opis { get; set; }
    public Clan _Clan { get; set; }
}