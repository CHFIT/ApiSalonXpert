﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(SalonXpertContext))]
    [Migration("20231013162115_añadimosLogin")]
    partial class añadimosLogin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.Citas", b =>
                {
                    b.Property<int>("IdCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCita"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCita");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("DB.Clientes", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<int>("IdCorporación")
                        .HasColumnType("int");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int");

                    b.Property<int>("Movil")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TiempoCita")
                        .HasColumnType("int");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DB.Corporacion", b =>
                {
                    b.Property<int>("IdCorporacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCorporacion"));

                    b.Property<string>("Denominacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Movil")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCorporacion");

                    b.ToTable("Corporacion");
                });

            modelBuilder.Entity("DB.Facturacion", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int");

                    b.Property<int>("Pago")
                        .HasColumnType("int");

                    b.HasKey("IdFactura");

                    b.ToTable("Facturacion");
                });

            modelBuilder.Entity("DB.Login", b =>
                {
                    b.Property<int>("IdLogin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLogin"));

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<int>("IdCorporacion")
                        .HasColumnType("int");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLogin");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("DB.Servicios", b =>
                {
                    b.Property<int>("IdServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServicio"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IdServicio");

                    b.ToTable("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}
