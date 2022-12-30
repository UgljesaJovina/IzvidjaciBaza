using Repositories.Models;

namespace Repositories.DTOs;

public class PohvalaShortObj
{
    public Guid Id { get; set; }
    public string Opis { get; set; }

    public PohvalaShortObj(Guid id, string opis)
    {
        Id = id;
        Opis = opis;
    }

    public PohvalaShortObj(Pohvala pohvala) :this(pohvala.Id, pohvala.Opis){}

    public static ICollection<PohvalaShortObj> TransformList(ICollection<Pohvala> pohvale) {
        return pohvale.Select(k => new PohvalaShortObj(k)).ToList();
    }
}