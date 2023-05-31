using Repositories.Models;

namespace Services.DTOs;

public class OFuncDisplay
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }
    public ICollection<CFuncShortObject> ClanskeFunkcije { get; }

    public OFuncDisplay(Guid id, string naziv, ICollection<ClanFunkcija> cFunkcije)
    {
        Id = id;
        Naziv = naziv;
        ClanskeFunkcije = CFuncShortObject.TransformList(cFunkcije);
    }

    public OFuncDisplay() { }

    public OFuncDisplay(OdredskaFunkcija funkcija) 
        : this(funkcija.Id, funkcija.Naziv, funkcija.ClanskeFunkcije) { }
}