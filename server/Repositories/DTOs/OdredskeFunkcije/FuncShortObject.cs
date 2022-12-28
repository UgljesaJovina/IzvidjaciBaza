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

    public static FuncShortObject? GetShortObject(OdredskaFunkcija? funkcija){
        if (funkcija is null) return null;
        return new FuncShortObject(funkcija.Id, funkcija.Naziv); 
    }

    public static ICollection<FuncShortObject?> TransformList(ICollection<OdredskaFunkcija> funckije) {
        return funckije.Select(f => FuncShortObject.GetShortObject(f)).ToList();
    }
}