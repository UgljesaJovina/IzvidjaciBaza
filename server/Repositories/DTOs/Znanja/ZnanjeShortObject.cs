using Repositories.Enums;
using Repositories.Models;

namespace Repositories.DTOs;

public class ZnanjeShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Znanje Znanje { get; set; }
    public int Broj { get; set; }
    public DateTime? DatumDobijanja { get; set; }

    public ZnanjeShortObject(Guid id, Znanje znanje, int broj, DateTime? datumDobijanja)
    {
        Id = id;
        Znanje = znanje;
        Broj = broj;
        DatumDobijanja = datumDobijanja;
    }

    public ZnanjeShortObject(ClanZnanje clanZnanje)
        :this(clanZnanje.Id, clanZnanje.Znanje, clanZnanje.Broj, clanZnanje.DatumDobijanja) {}

    public static ICollection<ZnanjeShortObject> TransformList(ICollection<ClanZnanje> znanja) {
        return znanja.Select(z => new ZnanjeShortObject(z)).ToList();
    }
}