using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;

/// <summary>
/// Ovo su sva vestarstva i vestine koje neko moze da ima
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

    [Required]
    public DateTime DatumDobijanja { get; set; }
    public Clan Clan { get; set; }
    
    public PosebanProgram() {}

    public PosebanProgram(string naziv, TipPrograma tip, DateTime datumDobijanja)
    {
        Naziv = naziv;
        Tip = tip;
        DatumDobijanja = datumDobijanja;
    }
}