using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebReceipt.Migrations
{
    /// <inheritdoc />
    public partial class Migration9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PaymentTypeId",
                table: "Form56s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Form56s_PaymentTypeId",
                table: "Form56s",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Form56s_PaymentTypes_PaymentTypeId",
                table: "Form56s",
                column: "PaymentTypeId",
                principalTable: "PaymentTypes",
                principalColumn: "PaymentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Form56s_PaymentTypes_PaymentTypeId",
                table: "Form56s");

            migrationBuilder.DropIndex(
                name: "IX_Form56s_PaymentTypeId",
                table: "Form56s");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "Form56s");
        }
    }
}
