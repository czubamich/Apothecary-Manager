using Microsoft.EntityFrameworkCore.Migrations;

namespace ApothecaryData.Migrations
{
    public partial class firstMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetail_Sales_SaleRefId",
                table: "SalesDetail");

            migrationBuilder.AlterColumn<int>(
                name: "SaleRefId",
                table: "SalesDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetail_Sales_SaleRefId",
                table: "SalesDetail",
                column: "SaleRefId",
                principalTable: "Sales",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetail_Sales_SaleRefId",
                table: "SalesDetail");

            migrationBuilder.AlterColumn<int>(
                name: "SaleRefId",
                table: "SalesDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetail_Sales_SaleRefId",
                table: "SalesDetail",
                column: "SaleRefId",
                principalTable: "Sales",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
