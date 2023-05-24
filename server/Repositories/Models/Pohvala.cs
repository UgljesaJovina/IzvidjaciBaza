using System.ComponentModel.DataAnnotations;

namespace Repositories.Models;

public class Pohvala
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    [Required]
    public DateTime DatumDobijanja { get; set; }
    public string? DodeljivacPohvale { get; set; }
    [Required]
    public string Opis { get; set; }
    [Required]
    public Clan Clan { get; set; }

    public Pohvala(DateTime datumDobijanja, string? dodeljivacPohvale, string opis)
    {
        DatumDobijanja = datumDobijanja;
        DodeljivacPohvale = dodeljivacPohvale;
        Opis = opis;
    }

    public Pohvala(Guid id, DateTime datumDobijanja, string? dodeljivacPohvale, string opis) 
    :this(datumDobijanja, dodeljivacPohvale, opis)
    {
        Id = id;
    }

    public Pohvala() { } 

}