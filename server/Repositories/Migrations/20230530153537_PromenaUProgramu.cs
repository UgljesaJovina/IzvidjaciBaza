using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class PromenaUProgramu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PosebniProgrami_Clanovi_ClanId",
                table: "PosebniProgrami");

            migrationBuilder.DropIndex(
                name: "IX_PosebniProgrami_ClanId",
                table: "PosebniProgrami");

            migrationBuilder.DropColumn(
                name: "ClanId",
                table: "PosebniProgrami");

            migrationBuilder.DropColumn(
                name: "DatumDobijanja",
                table: "PosebniProgrami");

            migrationBuilder.CreateTable(
                name: "ClanskiProgrami",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProgramId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatumDobijanja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanskiProgrami", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClanskiProgrami_Clanovi_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clanovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClanskiProgrami_PosebniProgrami_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "PosebniProgrami",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClanskiProgrami_ClanId",
                table: "ClanskiProgrami",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_ClanskiProgrami_ProgramId",
                table: "ClanskiProgrami",
                column: "ProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClanskiProgrami");

            migrationBuilder.AddColumn<Guid>(
                name: "ClanId",
                table: "PosebniProgrami",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumDobijanja",
                table: "PosebniProgrami",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_PosebniProgrami_ClanId",
                table: "PosebniProgrami",
                column: "ClanId");

            migrationBuilder.AddForeignKey(
                name: "FK_PosebniProgrami_Clanovi_ClanId",
                table: "PosebniProgrami",
                column: "ClanId",
                principalTable: "Clanovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
