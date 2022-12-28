using Repositories.Models;

namespace Repositories.DTOs;

public class AkcijaShortObject
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }

    public AkcijaShortObject(Guid id, string naziv)
    {
        Id = id;
        Naziv = naziv;
    }

    public static AkcijaShortObject? GetShortObject(Akcija? akcija){
        if (akcija is null) return null;
        return new AkcijaShortObject(akcija.Id, akcija.Naziv);
    }

    public static ICollection<AkcijaShortObject?> TransformList(ICollection<Akcija> akcije){
        return akcije.Select(a => AkcijaShortObject.GetShortObject(a)).ToList();
    }
}