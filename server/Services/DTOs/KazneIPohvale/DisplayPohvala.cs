using Repositories.Models;

namespace Services.DTOs;

public class DisplayPohvala
{
    public Guid Id { get; set; }
    public DateTime DatumDobijanja { get; set; }
    public string? DodeljivacPohvale { get; set; }
    public string Opis { get; set; }

    public DisplayPohvala(Guid id, DateTime datumDobijanja, string? dodeljivacPohvale, string opis)
    {
        Id = id;
        DatumDobijanja = datumDobijanja;
        DodeljivacPohvale = dodeljivacPohvale;
        Opis = opis;
    }

    public DisplayPohvala(Pohvala p) :this(p.Id, p.DatumDobijanja, p.DodeljivacPohvale, p.Opis) { }

    public Pohvala GetPohvala() {
        return new Pohvala(Id, DatumDobijanja, DodeljivacPohvale, Opis);
    }
}