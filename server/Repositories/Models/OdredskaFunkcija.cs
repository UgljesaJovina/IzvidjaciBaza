using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

public class OdredskaFunkcija
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Naziv { get; set; }
    public virtual ICollection<Clan> Clanovi { get; set; }
}