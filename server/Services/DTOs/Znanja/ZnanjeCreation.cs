using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class ZnanjeCreation
{
    public Znanje Znanje { get; set; }
    public int Broj { get; set; }
    public DateTime DatumDobijanja { get; set; }

    public ZnanjeCreation() { }

    public ClanZnanje GetZnanje() {
        return new(Znanje, Broj, DatumDobijanja);
    }
}