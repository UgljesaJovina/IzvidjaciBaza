using Repositories.Models;

namespace Services.DTOs;

public class CFuncShortObject
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }
    public bool Aktivna { get; set; }

    public CFuncShortObject(Guid id, string naziv, bool aktivna)
    {
        Id = id;
        Naziv = naziv;
        Aktivna = aktivna;
    }

    public CFuncShortObject(ClanFunkcija funkcija) 
        :this(funkcija.Id, funkcija.Funkcija.Naziv, funkcija.Aktivna){}

    public static ICollection<CFuncShortObject> TransformList(ICollection<ClanFunkcija> funckije) {
        return funckije.Select(f => new CFuncShortObject(f)).ToList();
    }
}