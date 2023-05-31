using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class DisplayPosProg
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }
    public string Tip { get; set; }

    public DisplayPosProg(Guid id, string naziv, TipPrograma tip)
    {
        Id = id;
        Naziv = naziv;
        Tip = tip.ToString();
    }

    public DisplayPosProg(PosebanProgram program) 
        : this(program.Id, program.Naziv, program.Tip) {}

    public static ICollection<DisplayPosProg> TransformList(ICollection<PosebanProgram> programi){
        return programi.Select(p => new DisplayPosProg(p)).ToList();
    }
}
