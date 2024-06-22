using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebReceipt.Migrations
{
    /// <inheritdoc />
    public partial class Migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PaymentTypeId",
                table: "Cedulas",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Cedulas_PaymentTypeId",
                table: "Cedulas",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cedulas_PaymentTypes_PaymentTypeId",
                table: "Cedulas",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "PaymentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cedulas_PaymentTypes_PaymentTypeId",
                table: "Cedulas");

            migrationBuilder.DropIndex(
                name: "IX_Cedulas_PaymentTypeId",
                table: "Cedulas");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "Cedulas");
        }
    }
}
