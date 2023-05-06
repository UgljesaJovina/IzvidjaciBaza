using Repositories.Models;

namespace Services.DTOs;

public class TecajShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }

    public TecajShortObject(Guid id, string naziv)
    {
        Id = id;
        Naziv = naziv;
    }

    public TecajShortObject(Tecaj tecaj) :this(tecaj.Id, tecaj.Naziv) {}

    public static ICollection<TecajShortObject> TransformList(ICollection<Tecaj> tecajevi) {
        return tecajevi.Select(t => new TecajShortObject(t)).ToList();
    }
}