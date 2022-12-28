using Repositories.Enums;
using Repositories.Models;

namespace Repositories.DTOs;

public class VodShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }
    public Kategorija Kategorija { get; set; }

    public VodShortObject(Guid id, string naziv, Kategorija kategorija)
    {
        Id = id;
        Naziv = naziv;
        Kategorija = kategorija;
    }

    public static VodShortObject? GetShortObject(Vod? vod) {
        if (vod is null) return null;
        return new VodShortObject(vod.Id, vod.Naziv, vod.Kategorija);
    }
}