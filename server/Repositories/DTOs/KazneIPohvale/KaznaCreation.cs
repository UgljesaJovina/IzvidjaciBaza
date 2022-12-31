using Repositories.Models;

namespace Repositories.DTOs;

public class KaznaCreation
{
    public DateTime DatumDobijanja { get; set; }
    public DateTime? DatumIsteka { get; set; }
    public string? DodeljivacKazne { get; set; }
    public string Opis { get; set; }

    public Kazna GetKazna(){
        return new Kazna(DatumDobijanja, DatumIsteka, DodeljivacKazne, Opis);
    }
}