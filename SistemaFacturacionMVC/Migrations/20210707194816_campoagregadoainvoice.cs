using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturacionMVC.Migrations
{
    public partial class campoagregadoainvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "estadisticasFacturas",
                columns: table => new
                {
                    Total_facturas = table.Column<int>(type: "int", nullable: false),
                    monto_facturado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    total_Productos = table.Column<int>(type: "int", nullable: false),
                    dateInvoice = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "spProducts",
                columns: table => new
                {
                    idProduct = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total_Vendido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dateInvoice = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "estadisticasFacturas");

            migrationBuilder.DropTable(
                name: "spProducts");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "invoice");
        }
    }
}
