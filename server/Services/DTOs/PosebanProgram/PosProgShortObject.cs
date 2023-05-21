using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class PosProgShortObject
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Naziv { get; set; }
    public string Tip { get; set; }

    public PosProgShortObject(Guid id, string naziv, TipPrograma tip)
    {
        Id = id;
        Naziv = naziv;
        Tip = tip.ToString();
    }

    public PosProgShortObject(PosebanProgram program) : this(program.Id, program.Naziv, program.Tip) {}

    public static ICollection<PosProgShortObject> TransformList(ICollection<PosebanProgram> programi){
        return programi.Select(p => new PosProgShortObject(p)).ToList();
    }
}