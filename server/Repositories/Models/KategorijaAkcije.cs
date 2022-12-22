using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repositories.Models;

public class KategorijaAkcije
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [StringLength(25)]
    public string Naziv { get; set; }
    public virtual ICollection<Akcija> Akcije { get; set; } = new List<Akcija>();
}