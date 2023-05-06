using Repositories.Models;

namespace Services.DTOs;

public class AkcijaShortObject
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }

    public AkcijaShortObject(Guid id, string naziv)
    {
        Id = id;
        Naziv = naziv;
    }

    public AkcijaShortObject(Akcija akcija) :this(akcija.Id, akcija.Naziv){}

    public static ICollection<AkcijaShortObject> TransformList(ICollection<Akcija> akcije){
        return akcije.Select(a => new AkcijaShortObject(a)).ToList();
    }
}