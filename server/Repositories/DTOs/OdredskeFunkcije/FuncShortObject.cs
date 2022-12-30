using Repositories.Models;

namespace Repositories.DTOs;

public class FuncShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }

    public FuncShortObject(Guid id, string naziv)
    {
        Id = id;
        Naziv = naziv;
    }

    public FuncShortObject(OdredskaFunkcija funkcija) :this(funkcija.Id, funkcija.Naziv){}

    public static ICollection<FuncShortObject> TransformList(ICollection<OdredskaFunkcija> funckije) {
        return funckije.Select(f => new FuncShortObject(f)).ToList();
    }
}