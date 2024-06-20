using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebReceipt.Migrations
{
    /// <inheritdoc />
    public partial class Migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityTreasurer",
                table: "Cedulas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CivilStatus",
                table: "Cedulas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Cedulas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Cedulas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfIssue",
                table: "Cedulas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Tin",
                table: "Cedulas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Cedulas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityTreasurer",
                table: "Cedulas");

            migrationBuilder.DropColumn(
                name: "CivilStatus",
                table: "Cedulas");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Cedulas");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Cedulas");

            migrationBuilder.DropColumn(
                name: "PlaceOfIssue",
                table: "Cedulas");

            migrationBuilder.DropColumn(
                name: "Tin",
                table: "Cedulas");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Cedulas");
        }
    }
}
