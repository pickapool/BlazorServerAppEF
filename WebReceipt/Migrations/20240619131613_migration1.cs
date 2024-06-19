using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebReceipt.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    UserAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAccountPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.UserAccountId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    ReceiptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRecorded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fund = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Cash = table.Column<bool>(type: "bit", nullable: false),
                    Check = table.Column<bool>(type: "bit", nullable: false),
                    MoneyOrder = table.Column<bool>(type: "bit", nullable: false),
                    CollectionOfficer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DraweeBank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DraweeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DraweeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentTypeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.ReceiptId);
                    table.ForeignKey(
                        name: "FK_Receipts_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "PaymentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NatureOfCollections",
                columns: table => new
                {
                    NatureOfCollectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NatureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiptId = table.Column<int>(type: "int", nullable: false),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureOfCollections", x => x.NatureOfCollectionId);
                    table.ForeignKey(
                        name: "FK_NatureOfCollections_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "ReceiptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NatureOfCollections_ReceiptId",
                table: "NatureOfCollections",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_PaymentTypeId",
                table: "Receipts",
                column: "PaymentTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "NatureOfCollections");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "PaymentTypes");
        }
    }
}
