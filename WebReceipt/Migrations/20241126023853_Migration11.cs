using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebReceipt.Migrations
{
    /// <inheritdoc />
    public partial class Migration11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBasic",
                table: "Form56s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSpecial",
                table: "Form56s",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBasic",
                table: "Form56s");

            migrationBuilder.DropColumn(
                name: "IsSpecial",
                table: "Form56s");
        }
    }
}
