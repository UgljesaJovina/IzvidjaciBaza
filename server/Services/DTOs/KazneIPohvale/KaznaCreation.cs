using Repositories.Models;

namespace Services.DTOs;

public class KaznaCreation
{
    public DateTime DatumDobijanja { get; set; }
    public DateTime? DatumIsteka { get; set; }
    public string? DodeljivacKazne { get; set; }
    public string Opis { get; set; }

    public Kazna GetKazna(){
        return new Kazna(DatumDobijanja, DatumIsteka, DodeljivacKazne, Opis);
    }

    // public void Update(Kazna k) {
    //     k.DatumDobijanja = DatumDobijanja;
    //     k.DatumIsteka = DatumIsteka;
    //     k.DodeljivacKazne = DodeljivacKazne;
    //     k.Opis = Opis;
    // }
}