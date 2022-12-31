using Repositories.Models;

namespace Repositories.DTOs;

public class KaznaListObject
{
    public Guid Id { get; set; }
    public string Opis { get; set; }

    public KaznaListObject(Guid id, string opis)
    {
        Id = id;
        Opis = opis;
    }

    public KaznaListObject(Kazna kazna) :this(kazna.Id, kazna.Opis){}

    public static ICollection<KaznaListObject> TransformList(ICollection<Kazna> kazne) {
        return kazne.Select(k => new KaznaListObject(k)).ToList();
    }
}