using Repositories.Models;

namespace Services.DTOs;

public class AkcijaListObject
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }
    public DateTime DatumPocetka { get; set; }
    public DateTime? DatumKraja { get; set; }
    public TipAkcije? Tip { get; set; }
    public OblikAkcije? Oblik { get; set; }

    public AkcijaListObject(Guid id, string naziv, DateTime datumPocetka, DateTime? datumKraja, TipAkcije? tip, OblikAkcije? oblik)
    {
        Id = id;
        Naziv = naziv;
        DatumPocetka = datumPocetka;
        DatumKraja = datumKraja;
        Tip = tip;
        Oblik = oblik;
    }

    public AkcijaListObject(Akcija akcija) :this(akcija.Id, akcija.Naziv, akcija.DatumPocetka, akcija.DatumKraja, akcija.Tip, akcija.Oblik) {}
}