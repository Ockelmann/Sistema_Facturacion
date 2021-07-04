using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Facturacion.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Codigo_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefonos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Codigo_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Codigo_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Existencia = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Codigo_Producto);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id_usuario);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Numero_Factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total_Factura = table.Column<double>(type: "float", nullable: false),
                    Anulada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo_Clientefk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Numero_Factura);
                    table.ForeignKey(
                        name: "FK_Facturas_Clientes_Codigo_Clientefk",
                        column: x => x.Codigo_Clientefk,
                        principalTable: "Clientes",
                        principalColumn: "Codigo_Cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factura_Productos",
                columns: table => new
                {
                    Numero_Facturafk = table.Column<int>(type: "int", nullable: false),
                    Codigo_Productofk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio_Unitario = table.Column<double>(type: "float", nullable: false),
                    FacturaNumero_Factura = table.Column<int>(type: "int", nullable: true),
                    ProductosCodigo_Producto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura_Productos", x => new { x.Numero_Facturafk, x.Codigo_Productofk });
                    table.ForeignKey(
                        name: "FK_Factura_Productos_Facturas_FacturaNumero_Factura",
                        column: x => x.FacturaNumero_Factura,
                        principalTable: "Facturas",
                        principalColumn: "Numero_Factura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Productos_Productos_ProductosCodigo_Producto",
                        column: x => x.ProductosCodigo_Producto,
                        principalTable: "Productos",
                        principalColumn: "Codigo_Producto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Productos_FacturaNumero_Factura",
                table: "Factura_Productos",
                column: "FacturaNumero_Factura");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Productos_ProductosCodigo_Producto",
                table: "Factura_Productos",
                column: "ProductosCodigo_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_Codigo_Clientefk",
                table: "Facturas",
                column: "Codigo_Clientefk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factura_Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
