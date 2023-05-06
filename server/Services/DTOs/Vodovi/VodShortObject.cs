using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class VodShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }

    public VodShortObject(Guid id, string naziv)
    {
        Id = id;
        Naziv = naziv;
    }

    public static VodShortObject? GetShortObject(Vod? vod) {
        if (vod is null) return null;
        return new VodShortObject(vod.Id, vod.Naziv);
    }
}