using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebReceipt.Migrations
{
    /// <inheritdoc />
    public partial class Migration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Form56s",
                columns: table => new
                {
                    Form56Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormNo = table.Column<int>(type: "int", nullable: false),
                    PreviousReceiptNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReceiveFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pesos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxType = table.Column<int>(type: "int", nullable: false),
                    CheckNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Treasurere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deputy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form56s", x => x.Form56Id);
                });

            migrationBuilder.CreateTable(
                name: "Form56Details",
                columns: table => new
                {
                    Form56DetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Form56Id = table.Column<int>(type: "int", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Block = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Land = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Improvements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssesedTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxDue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallmentNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallmentPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Penalty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form56Details", x => x.Form56DetailId);
                    table.ForeignKey(
                        name: "FK_Form56Details_Form56s_Form56Id",
                        column: x => x.Form56Id,
                        principalTable: "Form56s",
                        principalColumn: "Form56Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Form56Details_Form56Id",
                table: "Form56Details",
                column: "Form56Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Form56Details");

            migrationBuilder.DropTable(
                name: "Form56s");
        }
    }
}
