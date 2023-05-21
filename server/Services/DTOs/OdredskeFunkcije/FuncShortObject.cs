using Repositories.Models;

namespace Services.DTOs;

public class FuncShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }
    public bool Aktivna { get; set; }

    public FuncShortObject(Guid id, string naziv, bool aktivna)
    {
        Id = id;
        Naziv = naziv;
        Aktivna = aktivna;
    }

    public FuncShortObject(ClanFunkcija funkcija) :this(funkcija.Id, funkcija.Funkcija.Naziv, funkcija.TrenutnoAktivna){}

    public static ICollection<FuncShortObject> TransformList(ICollection<ClanFunkcija> funckije) {
        return funckije.Select(f => new FuncShortObject(f)).ToList();
    }
}