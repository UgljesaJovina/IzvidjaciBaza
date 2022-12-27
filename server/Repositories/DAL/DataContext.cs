using Microsoft.EntityFrameworkCore;
using Repositories.Models;

namespace Repositories.DAL;

public class DataContext : DbContext {
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}

    public DbSet<Clan> Clanovi { get; set; }
    public DbSet<Clanarina> Clanarine { get; set; }
    public DbSet<OdredskaFunkcija> OdredskeFunkcije { get; set; }
    public DbSet<ClanZnanje> ClanoviZnanja { get; set; }
    public DbSet<PosebanProgram> PosebniProgrami { get; set; }
    public DbSet<Pohvala> Pohvale { get; set; }
    public DbSet<Kazna> Kazne { get; set; }
    public DbSet<Vod> Vodovi { get; set; }
    public DbSet<Akcija> Akcije { get; set; }
    public DbSet<TipAkcije> TipoviAkcija { get; set; }
    public DbSet<OblikAkcije> ObliciAkcija { get; set; }
    public DbSet<Tecaj> Tecajevi { get; set; }
}