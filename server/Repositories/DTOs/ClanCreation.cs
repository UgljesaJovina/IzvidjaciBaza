using Repositories.Models;

namespace Repositories.DTOs;

public class ClanCreation
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public DateTime DatumUclanjenja { get; set; } = DateTime.Today;

    public ClanCreation(string ime, string prezime, DateTime datumRodjenja)
    {
        Ime = ime;
        Prezime = prezime;
        DatumRodjenja = datumRodjenja;
    }
    public ClanCreation(){}

    public ClanCreation(string ime, string prezime, DateTime datumRodjenja, DateTime datumUclanjenja) : this(ime, prezime, datumRodjenja)
    {
        DatumUclanjenja = datumUclanjenja;
    }

    public Clan GetClan(){
        return new Clan(Ime, Prezime, DatumRodjenja, DatumUclanjenja);
    }
}