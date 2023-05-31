using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class NekePromene : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrenutnoAktivna",
                table: "FunkcijeClanova",
                newName: "Aktivna");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumDobijanja",
                table: "FunkcijeClanova",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumDobijanja",
                table: "FunkcijeClanova");

            migrationBuilder.RenameColumn(
                name: "Aktivna",
                table: "FunkcijeClanova",
                newName: "TrenutnoAktivna");
        }
    }
}
