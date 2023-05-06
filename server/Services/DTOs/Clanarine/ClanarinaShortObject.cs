using Repositories.Models;

namespace Services.DTOs;

public class ClanarinaShortObject
{
    public Guid Id { get; set; }
    public DateTime DatumPlacanja { get; set; }
    public int GodinaClanarine { get; set; }
    public int? Iznos { get; set; }

    public ClanarinaShortObject(Guid id, DateTime datumPlacanja, int godinaClanarine, int? iznos)
    {
        Id = id;
        DatumPlacanja = datumPlacanja;
        GodinaClanarine = godinaClanarine;
        Iznos = iznos;
    }

    public ClanarinaShortObject(Clanarina clanarina) : this(clanarina.Id, clanarina.DatumPlacanja, clanarina.GodinaClanarine, clanarina.Iznos) {}

    public static ICollection<ClanarinaShortObject> TransfromList(ICollection<Clanarina> clanarine) {
        return clanarine.Select(c => new ClanarinaShortObject(c)).ToList();
    }
}