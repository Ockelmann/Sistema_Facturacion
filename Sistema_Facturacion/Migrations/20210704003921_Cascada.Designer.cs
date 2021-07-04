﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_Facturacion.DB;

namespace Sistema_Facturacion.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20210704003921_Cascada")]
    partial class Cascada
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sistema_Facturacion.Models.Cliente", b =>
                {
                    b.Property<int>("Codigo_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo_Cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Factura", b =>
                {
                    b.Property<int>("Numero_Factura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anulada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Codigo_Clientefk")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<double>("Total_Factura")
                        .HasColumnType("float");

                    b.HasKey("Numero_Factura");

                    b.HasIndex("Codigo_Clientefk");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Factura_Productos", b =>
                {
                    b.Property<int?>("Numero_Facturafk")
                        .HasColumnType("int");

                    b.Property<int?>("Codigo_Productofk")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("FacturaNumero_Factura")
                        .HasColumnType("int");

                    b.Property<double>("Precio_Unitario")
                        .HasColumnType("float");

                    b.Property<int?>("ProductosCodigo_Producto")
                        .HasColumnType("int");

                    b.HasKey("Numero_Facturafk", "Codigo_Productofk");

                    b.HasIndex("FacturaNumero_Factura");

                    b.HasIndex("ProductosCodigo_Producto");

                    b.ToTable("Factura_Productos");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Producto", b =>
                {
                    b.Property<int>("Codigo_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<int>("Existencia")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo_Producto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Reporte_Cliente", b =>
                {
                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Total");

                    b.ToTable("Reporte_Clientes");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Reporte_Estadistica", b =>
                {
                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("Cantidad_Productos")
                        .HasColumnType("int");

                    b.Property<string>("Dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Facturas_Emitidas")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Total");

                    b.ToTable("Reporte_Estadistica");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Reporte_Productos", b =>
                {
                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("Codigo_Producto")
                        .HasColumnType("int");

                    b.Property<string>("Dia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Total");

                    b.ToTable("Reporte_Productos");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Usuario", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Factura", b =>
                {
                    b.HasOne("Sistema_Facturacion.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("Codigo_Clientefk")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Sistema_Facturacion.Models.Factura_Productos", b =>
                {
                    b.HasOne("Sistema_Facturacion.Models.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("FacturaNumero_Factura");

                    b.HasOne("Sistema_Facturacion.Models.Producto", "Productos")
                        .WithMany()
                        .HasForeignKey("ProductosCodigo_Producto");

                    b.Navigation("Factura");

                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
