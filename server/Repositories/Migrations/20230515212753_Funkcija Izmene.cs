using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class FunkcijaIzmene : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clanovi_OdredskeFunkcije_OdredskaFunkcijaId",
                table: "Clanovi");

            migrationBuilder.DropIndex(
                name: "IX_Clanovi_OdredskaFunkcijaId",
                table: "Clanovi");

            migrationBuilder.DropColumn(
                name: "OdredskaFunkcijaId",
                table: "Clanovi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OdredskaFunkcijaId",
                table: "Clanovi",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clanovi_OdredskaFunkcijaId",
                table: "Clanovi",
                column: "OdredskaFunkcijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clanovi_OdredskeFunkcije_OdredskaFunkcijaId",
                table: "Clanovi",
                column: "OdredskaFunkcijaId",
                principalTable: "OdredskeFunkcije",
                principalColumn: "Id");
        }
    }
}
