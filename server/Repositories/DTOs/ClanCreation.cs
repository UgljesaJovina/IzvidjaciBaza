using Repositories.Enums;
using Repositories.Models;

namespace Repositories.DTOs;

public class ClanCreation
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public DateTime DatumUclanjenja { get; set; }
    public DateTime? DatumZaveta { get; set; }
    public string? Adresa { get; set; }
    public Kategorija? Kategorija { get; set; }

    public ClanCreation(string ime, string prezime, DateTime datumRodjenja, DateTime datumUclanjenja, DateTime? datumZaveta, string? adresa, Kategorija? kategorija)
    {
        Ime = ime;
        Prezime = prezime;
        DatumRodjenja = datumRodjenja;
        DatumUclanjenja = datumUclanjenja;
        DatumZaveta = datumZaveta;
        Adresa = adresa;
        Kategorija = kategorija;
    }

    public ClanCreation(){}

    public Clan GetClan(){
        return new Clan(Ime, Prezime, Kategorija, DatumRodjenja, DatumUclanjenja, DatumZaveta, Adresa);
    }
}