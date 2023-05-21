using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class ZnanjeShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Znanje { get; set; }
    public int Broj { get; set; }
    public DateTime? DatumDobijanja { get; set; }

    public ZnanjeShortObject(Guid id, string znanje, int broj, DateTime? datumDobijanja)
    {
        Id = id;
        Znanje = znanje;
        Broj = broj;
        DatumDobijanja = datumDobijanja;
    }

    public ZnanjeShortObject(ClanZnanje clanZnanje)
        :this(clanZnanje.Id, clanZnanje.Znanje.ToString(), clanZnanje.Broj, clanZnanje.DatumDobijanja) {}

    public static ICollection<ZnanjeShortObject> TransformList(ICollection<ClanZnanje> znanja) {
        return znanja.Select(z => new ZnanjeShortObject(z)).ToList();
    }
}