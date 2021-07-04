using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Facturacion.Migrations
{
    public partial class Cascada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_Codigo_Clientefk",
                table: "Facturas");

            
            

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_Codigo_Clientefk",
                table: "Facturas",
                column: "Codigo_Clientefk",
                principalTable: "Clientes",
                principalColumn: "Codigo_Cliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Clientes_Codigo_Clientefk",
                table: "Facturas");


            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Clientes_Codigo_Clientefk",
                table: "Facturas",
                column: "Codigo_Clientefk",
                principalTable: "Clientes",
                principalColumn: "Codigo_Cliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
