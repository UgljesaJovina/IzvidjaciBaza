using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Repositories.Models;

/// <summary>
/// Ovo su sva vestarstva i vestine koje neko moze da ima (na clanu)
/// <para>
/// TipPrograma enum: { Vestina, Vestarstvo, Specijalnost }
/// </para>
/// </summary>

public class ClanProgram
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Clan Clan { get; set; }
    public PosebanProgram Program { get; set; }
    public DateTime DatumDobijanja { get; set; }

    public ClanProgram SetClan(Clan c) {
        Clan = c;
        return this;
    }

    public ClanProgram SetProgram(PosebanProgram pp) {
        Program = pp;
        return this;
    }
}