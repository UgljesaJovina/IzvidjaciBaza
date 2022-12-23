using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClanoviZnanja",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Znanje = table.Column<int>(type: "int", nullable: false),
                    Broj = table.Column<int>(type: "int", nullable: false),
                    DatumDobijanja = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanoviZnanja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObliciAkcija",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObliciAkcija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OdredskeFunkcije",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdredskeFunkcije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PosebniProgrami",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Tip = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosebniProgrami", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecajevi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MestoOdrzavanja = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecajevi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoviAkcija",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviAkcija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vodovi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Kategorija = table.Column<int>(name: "_Kategorija", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vodovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Akcije",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    DatumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumKraja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MestoOdrzavanja = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TipId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OblikId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Akcije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Akcije_ObliciAkcija_OblikId",
                        column: x => x.OblikId,
                        principalTable: "ObliciAkcija",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Akcije_TipoviAkcija_TipId",
                        column: x => x.TipId,
                        principalTable: "TipoviAkcija",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clanovi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumUclanjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumDavanjaZaveta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clanovi_Vodovi_VodId",
                        column: x => x.VodId,
                        principalTable: "Vodovi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkcijaClan",
                columns: table => new
                {
                    AkcijeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClanoviId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkcijaClan", x => new { x.AkcijeId, x.ClanoviId });
                    table.ForeignKey(
                        name: "FK_AkcijaClan_Akcije_AkcijeId",
                        column: x => x.AkcijeId,
                        principalTable: "Akcije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkcijaClan_Clanovi_ClanoviId",
                        column: x => x.ClanoviId,
                        principalTable: "Clanovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClanClanZnanje",
                columns: table => new
                {
                    ClanoviId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZnanjaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanClanZnanje", x => new { x.ClanoviId, x.ZnanjaId });
                    table.ForeignKey(
                        name: "FK_ClanClanZnanje_ClanoviZnanja_ZnanjaId",
                        column: x => x.ZnanjaId,
                        principalTable: "ClanoviZnanja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClanClanZnanje_Clanovi_ClanoviId",
                        column: x => x.ClanoviId,
                        principalTable: "Clanovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClanOdredskaFunkcija",
                columns: table => new
                {
                    ClanoviId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FunkcijeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanOdredskaFunkcija", x => new { x.ClanoviId, x.FunkcijeId });
                    table.ForeignKey(
                        name: "FK_ClanOdredskaFunkcija_Clanovi_ClanoviId",
                        column: x => x.ClanoviId,
                        principalTable: "Clanovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClanOdredskaFunkcija_OdredskeFunkcije_FunkcijeId",
                        column: x => x.FunkcijeId,
                        principalTable: "OdredskeFunkcije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClanPosebanProgram",
                columns: table => new
                {
                    ClanoviId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PosebniProgramiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanPosebanProgram", x => new { x.ClanoviId, x.PosebniProgramiId });
                    table.ForeignKey(
                        name: "FK_ClanPosebanProgram_Clanovi_ClanoviId",
                        column: x => x.ClanoviId,
                        principalTable: "Clanovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClanPosebanProgram_PosebniProgrami_PosebniProgramiId",
                        column: x => x.PosebniProgramiId,
                        principalTable: "PosebniProgrami",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClanTecaj",
                columns: table => new
                {
                    ClanoviId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TecajeviId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanTecaj", x => new { x.ClanoviId, x.TecajeviId });
                    table.ForeignKey(
                        name: "FK_ClanTecaj_Clanovi_ClanoviId",
                        column: x => x.ClanoviId,
                        principalTable: "Clanovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClanTecaj_Tecajevi_TecajeviId",
                        column: x => x.TecajeviId,
                        principalTable: "Tecajevi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kazne",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatumDobijanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumIsteka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DodeljivacKazne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClanId = table.Column<Guid>(name: "_ClanId", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kazne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kazne_Clanovi__ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clanovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pohvale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatumDobijanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DodeljivacPohvale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClanId = table.Column<Guid>(name: "_ClanId", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pohvale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pohvale_Clanovi__ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clanovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AkcijaClan_ClanoviId",
                table: "AkcijaClan",
                column: "ClanoviId");

            migrationBuilder.CreateIndex(
                name: "IX_Akcije_OblikId",
                table: "Akcije",
                column: "OblikId");

            migrationBuilder.CreateIndex(
                name: "IX_Akcije_TipId",
                table: "Akcije",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_ClanClanZnanje_ZnanjaId",
                table: "ClanClanZnanje",
                column: "ZnanjaId");

            migrationBuilder.CreateIndex(
                name: "IX_ClanOdredskaFunkcija_FunkcijeId",
                table: "ClanOdredskaFunkcija",
                column: "FunkcijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clanovi_VodId",
                table: "Clanovi",
                column: "VodId");

            migrationBuilder.CreateIndex(
                name: "IX_ClanPosebanProgram_PosebniProgramiId",
                table: "ClanPosebanProgram",
                column: "PosebniProgramiId");

            migrationBuilder.CreateIndex(
                name: "IX_ClanTecaj_TecajeviId",
                table: "ClanTecaj",
                column: "TecajeviId");

            migrationBuilder.CreateIndex(
                name: "IX_Kazne__ClanId",
                table: "Kazne",
                column: "_ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_Pohvale__ClanId",
                table: "Pohvale",
                column: "_ClanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AkcijaClan");

            migrationBuilder.DropTable(
                name: "ClanClanZnanje");

            migrationBuilder.DropTable(
                name: "ClanOdredskaFunkcija");

            migrationBuilder.DropTable(
                name: "ClanPosebanProgram");

            migrationBuilder.DropTable(
                name: "ClanTecaj");

            migrationBuilder.DropTable(
                name: "Kazne");

            migrationBuilder.DropTable(
                name: "Pohvale");

            migrationBuilder.DropTable(
                name: "Akcije");

            migrationBuilder.DropTable(
                name: "ClanoviZnanja");

            migrationBuilder.DropTable(
                name: "OdredskeFunkcije");

            migrationBuilder.DropTable(
                name: "PosebniProgrami");

            migrationBuilder.DropTable(
                name: "Tecajevi");

            migrationBuilder.DropTable(
                name: "Clanovi");

            migrationBuilder.DropTable(
                name: "ObliciAkcija");

            migrationBuilder.DropTable(
                name: "TipoviAkcija");

            migrationBuilder.DropTable(
                name: "Vodovi");
        }
    }
}
