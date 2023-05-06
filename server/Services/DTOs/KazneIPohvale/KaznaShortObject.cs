using Repositories.Models;

namespace Services.DTOs;

public class KaznaShortObject
{
    public Guid Id { get; set; }
    public string Opis { get; set; }
    public DateTime? DatumIsteka { get; set; }

    public KaznaShortObject(Guid id, string opis, DateTime? datumIsteka)
    {
        Id = id;
        Opis = opis;
        DatumIsteka = datumIsteka;
    }

    public KaznaShortObject(Kazna kazna) :this(kazna.Id, kazna.Opis, kazna.DatumIsteka){}

    public static ICollection<KaznaShortObject> TransformList(ICollection<Kazna> kazne) {
        return kazne.Select(k => new KaznaShortObject(k)).ToList();
    }
}