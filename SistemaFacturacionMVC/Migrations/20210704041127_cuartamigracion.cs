using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaFacturacionMVC.Migrations
{
    public partial class cuartamigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dateInvoice",
                table: "invoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateInvoice",
                table: "invoice");
        }
    }
}
