using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebReceipt.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cedulas",
                columns: table => new
                {
                    CedulaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIssued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ORNumber = table.Column<int>(type: "int", nullable: false),
                    SureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ICRNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BasicCommunity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionCommunity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossCommunity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryCommunity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeCommunity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Municipality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Interest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Paid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cedulas", x => x.CedulaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cedulas");
        }
    }
}
