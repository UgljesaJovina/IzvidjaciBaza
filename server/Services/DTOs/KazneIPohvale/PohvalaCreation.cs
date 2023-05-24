using Repositories.Models;

namespace Services.DTOs;

public class PohvalaCreation
{

    public DateTime DatumDobijanja { get; set; }
    public string? DodeljivacPohvale { get; set; } 
    public string Opis { get; set; }

    public Pohvala GetPohvala() {
        return new Pohvala(DatumDobijanja, DodeljivacPohvale, Opis);
    }
}