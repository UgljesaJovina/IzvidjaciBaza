using Repositories.Models;

namespace Services.DTOs;

public class PohvalaShortObject
{
    public Guid Id { get; set; }
    public string Opis { get; set; }

    public PohvalaShortObject(Guid id, string opis)
    {
        Id = id;
        Opis = opis;
    }

    public PohvalaShortObject(Pohvala pohvala) :this(pohvala.Id, pohvala.Opis){}

    public static ICollection<PohvalaShortObject> TransformList(ICollection<Pohvala> pohvale) {
        return pohvale.Select(k => new PohvalaShortObject(k)).ToList();
    }
}