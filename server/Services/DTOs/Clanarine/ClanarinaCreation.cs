using Repositories.Models;

namespace Services.DTOs;

public class ClanarinaCreation
{
    public DateTime DatumPlacanja { get; set; }
    public int GodinaClanarine { get; set; }
    public int? Iznos { get; set; }

    public Clanarina GetClanarina() {
        return new Clanarina(DatumPlacanja, GodinaClanarine, Iznos);
    }
}