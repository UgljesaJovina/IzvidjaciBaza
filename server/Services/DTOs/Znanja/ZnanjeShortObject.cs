using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class ZnanjeShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Znanje { get; set; }
    public int Broj { get; set; }

    public ZnanjeShortObject(Guid id, Znanje znanje, int broj)
    {
        Id = id;
        Znanje = znanje.ToString();
        Broj = broj;
    }

    public ZnanjeShortObject(ClanZnanje clanZnanje)
        :this(clanZnanje.Id, clanZnanje.Znanje, clanZnanje.Broj) {}

    public static ICollection<ZnanjeShortObject> TransformList(ICollection<ClanZnanje> znanja) {
        return znanja.Select(z => new ZnanjeShortObject(z)).ToList();
    }
}