using Microsoft.EntityFrameworkCore.Migrations;

namespace ApothecaryData.Migrations
{
    public partial class UpdatedReverseProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesDetails");

            migrationBuilder.CreateTable(
                name: "SaleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionRefId = table.Column<int>(type: "int", nullable: true),
                    DrugRefId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Refund = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Prescriptions_PrescriptionRefId",
                        column: x => x.PrescriptionRefId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Sales_DrugRefId",
                        column: x => x.DrugRefId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_DrugRefId",
                table: "SaleDetails",
                column: "DrugRefId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_PrescriptionRefId",
                table: "SaleDetails",
                column: "PrescriptionRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleDetails");

            migrationBuilder.CreateTable(
                name: "SalesDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    DrugRefId = table.Column<int>(type: "int", nullable: false),
                    PrescriptionRefId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Refund = table.Column<double>(type: "float", nullable: false),
                    SaleRefId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesDetails_Prescriptions_PrescriptionRefId",
                        column: x => x.PrescriptionRefId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesDetails_Sales_DrugRefId",
                        column: x => x.DrugRefId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesDetails_Sales_SaleRefId",
                        column: x => x.SaleRefId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_DrugRefId",
                table: "SalesDetails",
                column: "DrugRefId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_PrescriptionRefId",
                table: "SalesDetails",
                column: "PrescriptionRefId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_SaleRefId",
                table: "SalesDetails",
                column: "SaleRefId");
        }
    }
}
