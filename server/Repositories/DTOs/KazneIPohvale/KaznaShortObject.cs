using Repositories.Models;

namespace Repositories.DTOs;

public class KaznaShortObject
{
    public Guid Id { get; set; }
    public string Opis { get; set; }

    public KaznaShortObject(Guid id, string opis)
    {
        Id = id;
        Opis = opis;
    }

    public KaznaShortObject(Kazna kazna) :this(kazna.Id, kazna.Opis){}

    public static ICollection<KaznaShortObject> TransformList(ICollection<Kazna> kazne) {
        return kazne.Select(k => new KaznaShortObject(k)).ToList();
    }
}