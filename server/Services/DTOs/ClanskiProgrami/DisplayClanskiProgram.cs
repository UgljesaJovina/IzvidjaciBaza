using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class DisplayClanskiProgram
{
    public Guid Id { get; set; }
    public string Naziv { get; set; }
    public string Tip { get; set; }
    public DateTime DatumDobijanja { get; set; }

    public DisplayClanskiProgram(Guid id, string naziv, TipPrograma tip, DateTime datumDobijanja)
    {
        Id = id;
        Naziv = naziv;
        Tip = tip.ToString();
        DatumDobijanja = datumDobijanja;
    }

    public DisplayClanskiProgram(ClanProgram cp)
        : this(cp.Id, cp.Program.Naziv, cp.Program.Tip, cp.DatumDobijanja) { }

    public static ICollection<DisplayClanskiProgram> TransformList(ICollection<ClanProgram> programi) {
        return programi.Select(p => new DisplayClanskiProgram(p)).ToList();
    }
}