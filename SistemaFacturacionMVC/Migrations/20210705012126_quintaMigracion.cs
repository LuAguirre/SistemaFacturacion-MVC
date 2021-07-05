using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturacionMVC.Migrations
{
    public partial class quintaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "invoiceProduct",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "invoiceProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "invoiceProduct");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "invoiceProduct");
        }
    }
}
