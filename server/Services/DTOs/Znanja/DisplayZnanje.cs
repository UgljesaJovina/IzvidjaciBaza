using Repositories.Models;

namespace Services.DTOs;

public class DisplayZnanje
{
    public Guid Id { get; set; }
    public string Znanje { get; set; }
    public int Broj { get; set; }
    public DateTime DatumDobijanja { get; set; }

    public DisplayZnanje(string znanje, int broj, DateTime datumDobijanja)
    {
        Znanje = znanje;
        Broj = broj;
        DatumDobijanja = datumDobijanja;
    }

    public DisplayZnanje(Guid id, string znanje, int broj, DateTime datumDobijanja)
        : this(znanje, broj, datumDobijanja)
    {
        Id = id;
    }

    public DisplayZnanje(ClanZnanje znanje)
        : this(znanje.Id, znanje.Znanje.ToString(), znanje.Broj, znanje.DatumDobijanja) {}
}