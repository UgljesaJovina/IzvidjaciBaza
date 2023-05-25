using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class PosebanProgramIzmena : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClanPosebanProgram");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_ClanPosebanProgram_PosebniProgramiId",
                table: "ClanPosebanProgram",
                column: "PosebniProgramiId");
        }
    }
}
