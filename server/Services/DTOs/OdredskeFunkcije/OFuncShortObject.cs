using Repositories.Models;

namespace Services.DTOs;

public class OFuncShortObject
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }

    public OFuncShortObject(Guid id, string naziv)
    {
        Id = id;
        Naziv = naziv;
    }

    public OFuncShortObject(OdredskaFunkcija func) 
        : this(func.Id, func.Naziv) { }
    
    public static ICollection<OFuncShortObject> TransformList(ICollection<OdredskaFunkcija> funckije) {
        return funckije.Select(f => new OFuncShortObject(f)).ToList();
    }
}