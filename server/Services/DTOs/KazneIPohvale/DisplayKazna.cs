using Repositories.Models;

namespace Services.DTOs;

public class DisplayKazna
{
    public DateTime DatumDobijanja { get; set; }
    public DateTime? DatumIsteka { get; set; }
    public string? DodeljivacKazne { get; set; }
    public string Opis { get; set; }

    public DisplayKazna(DateTime datumDobijanja, DateTime? datumIsteka, string? dodeljivacKazne, string opis)
    {
        DatumDobijanja = datumDobijanja;
        DatumIsteka = datumIsteka;
        DodeljivacKazne = dodeljivacKazne;
        Opis = opis;
    }

    public DisplayKazna(Kazna k) : this(k.DatumDobijanja, k.DatumIsteka, k.DodeljivacKazne, k.Opis) {}

    public Kazna GetKazna() {
        return new Kazna(DatumDobijanja, DatumIsteka, DodeljivacKazne, Opis);
    }
}