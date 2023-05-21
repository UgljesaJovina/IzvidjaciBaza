using Repositories.Models;

namespace Services.DTOs;

public class DisplayKazna
{
    public Guid Id { get; set; }
    public DateTime DatumDobijanja { get; set; }
    public DateTime? DatumIsteka { get; set; }
    public string? DodeljivacKazne { get; set; }
    public string Opis { get; set; }

    public DisplayKazna(Guid id, DateTime datumDobijanja, DateTime? datumIsteka, string? dodeljivacKazne, string opis)
    {
        Id = id;
        DatumDobijanja = datumDobijanja;
        DatumIsteka = datumIsteka;
        DodeljivacKazne = dodeljivacKazne;
        Opis = opis;
    }

    public DisplayKazna(Kazna k) : this(k.Id, k.DatumDobijanja, k.DatumIsteka, k.DodeljivacKazne, k.Opis) {}

    public Kazna GetKazna() {
        return new Kazna(Id, DatumDobijanja, DatumIsteka, DodeljivacKazne, Opis);
    }
}