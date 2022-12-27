using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ClanoviNameEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatumDavanjaZaveta",
                table: "Clanovi",
                newName: "DatumZaveta");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumUclanjenja",
                table: "Clanovi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatumZaveta",
                table: "Clanovi",
                newName: "DatumDavanjaZaveta");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumUclanjenja",
                table: "Clanovi",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
