using Repositories.Enums;
using Repositories.Models;

namespace Services.DTOs;

public class PosProgCreation
{
    public string Naziv { get; set; }
    public TipPrograma Tip { get; set; }
    public DateTime DatumDobijanja { get; set; }

    public PosProgCreation() {}

    public PosebanProgram GetProgram() {
        return new PosebanProgram(Naziv, Tip, DatumDobijanja);
    }
}