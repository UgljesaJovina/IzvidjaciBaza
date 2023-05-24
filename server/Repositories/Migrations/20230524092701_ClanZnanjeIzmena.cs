using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ClanZnanjeIzmena : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClanClanZnanje");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumDobijanja",
                table: "ClanoviZnanja",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClanId",
                table: "ClanoviZnanja",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClanoviZnanja_ClanId",
                table: "ClanoviZnanja",
                column: "ClanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClanoviZnanja_Clanovi_ClanId",
                table: "ClanoviZnanja",
                column: "ClanId",
                principalTable: "Clanovi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClanoviZnanja_Clanovi_ClanId",
                table: "ClanoviZnanja");

            migrationBuilder.DropIndex(
                name: "IX_ClanoviZnanja_ClanId",
                table: "ClanoviZnanja");

            migrationBuilder.DropColumn(
                name: "ClanId",
                table: "ClanoviZnanja");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumDobijanja",
                table: "ClanoviZnanja",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

            migrationBuilder.CreateIndex(
                name: "IX_ClanClanZnanje_ZnanjaId",
                table: "ClanClanZnanje",
                column: "ZnanjaId");
        }
    }
}
