using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class DisplayPosProg
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }
    public string Tip { get; set; }
    public DateTime DatumDobijanja { get; set; }

    public DisplayPosProg(Guid id, string naziv, TipPrograma tip, DateTime datumDobijanja)
    {
        Id = id;
        Naziv = naziv;
        Tip = tip.ToString();
        DatumDobijanja = datumDobijanja;
    }

    public DisplayPosProg(PosebanProgram program) 
        : this(program.Id, program.Naziv, program.Tip, program.DatumDobijanja) {}

    public static ICollection<DisplayPosProg> TransformList(ICollection<PosebanProgram> programi){
        return programi.Select(p => new DisplayPosProg(p)).ToList();
    }
}
