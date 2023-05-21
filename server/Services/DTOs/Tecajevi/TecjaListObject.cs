using Repositories.Models;

namespace Services.DTOs;

public class TecajListObject
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }
    public string? Opis { get; set; }
    public DateTime DatumPocetka { get; set; }
    public DateTime? DatumKraja { get; set; }

    public TecajListObject(Guid id, string naziv, string? opis, DateTime datumPocetka, DateTime? datumKraja)
    {
        Id = id;
        Naziv = naziv;
        Opis = opis;
        DatumPocetka = datumPocetka;
        DatumKraja = datumKraja;
    }

    public TecajListObject(Tecaj tecaj) :this(tecaj.Id, tecaj.Naziv, tecaj.Opis, tecaj.DatumPocetka, tecaj.DatumKraja) {}
}