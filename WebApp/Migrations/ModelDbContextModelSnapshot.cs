﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Models;

namespace WebApp.Migrations
{
    [DbContext(typeof(ModelDbContext))]
    partial class ModelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.Articulo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("WebApp.Models.ArticulosFactura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("articuloId")
                        .HasColumnType("int");

                    b.Property<int>("cantArticulo")
                        .HasColumnType("int");

                    b.Property<int>("facturaId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("articuloId");

                    b.HasIndex("facturaId");

                    b.ToTable("ArticulosFactura");
                });

            modelBuilder.Entity("WebApp.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("WebApp.Models.Factura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<string>("correl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("monto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("clienteId");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("WebApp.Models.ArticulosFactura", b =>
                {
                    b.HasOne("WebApp.Models.Articulo", "articulo")
                        .WithMany("articulosFacturas")
                        .HasForeignKey("articuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Factura", "factura")
                        .WithMany("articulosFacturas")
                        .HasForeignKey("facturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("articulo");

                    b.Navigation("factura");
                });

            modelBuilder.Entity("WebApp.Models.Factura", b =>
                {
                    b.HasOne("WebApp.Models.Cliente", "cliente")
                        .WithMany("facturas")
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("WebApp.Models.Articulo", b =>
                {
                    b.Navigation("articulosFacturas");
                });

            modelBuilder.Entity("WebApp.Models.Cliente", b =>
                {
                    b.Navigation("facturas");
                });

            modelBuilder.Entity("WebApp.Models.Factura", b =>
                {
                    b.Navigation("articulosFacturas");
                });
#pragma warning restore 612, 618
        }
    }
}
