using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;

/// <summary>
/// Ovo su sva vestarstva i vestine koje neko moze da ima (u bazi)
/// <para>
/// TipPrograma enum: { Vestina, Vestarstvo, Specijalnost }
/// </para>
/// </summary>
public class PosebanProgram
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(75)]
    public string Naziv { get; set; }

    [Required]
    public TipPrograma Tip { get; set; }

    public virtual ICollection<ClanProgram> ClanskiProgrami { get; set; } = new List<ClanProgram>();
    
    public PosebanProgram() {}

    public PosebanProgram(string naziv, TipPrograma tip)
    {
        Naziv = naziv;
        Tip = tip;
    }

    public static bool operator == (PosebanProgram pp1, PosebanProgram pp2) {
        return pp1.Naziv == pp2.Naziv && pp1.Tip == pp2.Tip;
    }

    public static bool operator != (PosebanProgram pp1, PosebanProgram pp2) {
        return pp1.Naziv != pp2.Naziv || pp1.Tip != pp2.Tip;
    }
}