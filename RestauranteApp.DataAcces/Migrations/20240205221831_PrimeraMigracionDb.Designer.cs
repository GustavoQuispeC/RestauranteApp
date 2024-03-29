﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestauranteApp.DataAcces.Data;

#nullable disable

namespace RestauranteApp.DataAcces.Migrations
{
    [DbContext(typeof(RestauranteAppDbContext))]
    [Migration("20240205221831_PrimeraMigracionDb")]
    partial class PrimeraMigracionDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestauranteApp.Entities.Caja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaApertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCierre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<float>("SaldoInicial")
                        .HasColumnType("real");

                    b.Property<float>("TotalRecaudado")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Caja");
                });

            modelBuilder.Entity("RestauranteApp.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Observacion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6010),
                            Nombre = "Parrilla",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 2,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6031),
                            Nombre = "Hamburguesa",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 3,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6035),
                            Nombre = "Gaseosa",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 4,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6037),
                            Nombre = "Cerveza",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 5,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6039),
                            Nombre = "Wisky",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 6,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6044),
                            Nombre = "Pisco",
                            Observacion = ""
                        });
                });

            modelBuilder.Entity("RestauranteApp.Entities.DetalleMovimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovimientoId")
                        .HasColumnType("int");

                    b.Property<string>("Observacion")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<float>("PrecioUnitario")
                        .HasColumnType("real");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("MovimientoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("DetalleMovimiento");
                });

            modelBuilder.Entity("RestauranteApp.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Observacion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Marca");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5584),
                            Nombre = "Inka Kola",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 2,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5613),
                            Nombre = "Coca Cola",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 3,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5615),
                            Nombre = "Queirolo",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 4,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5618),
                            Nombre = "Tabernero",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 5,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5620),
                            Nombre = "Pilsen",
                            Observacion = ""
                        });
                });

            modelBuilder.Entity("RestauranteApp.Entities.Movimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CajaId")
                        .HasColumnType("int");

                    b.Property<float>("Descuento")
                        .HasColumnType("real");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<float>("Monto")
                        .HasColumnType("real");

                    b.Property<float>("MontoFinal")
                        .HasColumnType("real");

                    b.Property<string>("Observacion")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("PagoRecibido")
                        .HasColumnType("real");

                    b.Property<float>("PagoVuelto")
                        .HasColumnType("real");

                    b.Property<int>("TipoPagoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CajaId");

                    b.HasIndex("TipoPagoId");

                    b.ToTable("Movimiento");
                });

            modelBuilder.Entity("RestauranteApp.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaVencimiento")
                        .HasColumnType("DATE");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Observacion")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<float>("PrecioCompra")
                        .HasColumnType("real");

                    b.Property<float>("PrecioVenta")
                        .HasColumnType("real");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("UnidadMedidaId")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ProveedorId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("RestauranteApp.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Observacion")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("RazonSocial")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("email")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("RestauranteApp.Entities.TipoPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Observacion")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("TipoPago");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 72, DateTimeKind.Local).AddTicks(8977),
                            Nombre = "Efectivo",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 2,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 72, DateTimeKind.Local).AddTicks(9004),
                            Nombre = "Transferencia",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 3,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 72, DateTimeKind.Local).AddTicks(9007),
                            Nombre = "Yape",
                            Observacion = ""
                        },
                        new
                        {
                            Id = 4,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 72, DateTimeKind.Local).AddTicks(9009),
                            Nombre = "Plin",
                            Observacion = ""
                        });
                });

            modelBuilder.Entity("RestauranteApp.Entities.UnidadMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("UnidadMedida");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 73, DateTimeKind.Local).AddTicks(1689),
                            Nombre = "Unidad"
                        },
                        new
                        {
                            Id = 2,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 73, DateTimeKind.Local).AddTicks(1703),
                            Nombre = "Litro"
                        },
                        new
                        {
                            Id = 3,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 73, DateTimeKind.Local).AddTicks(1706),
                            Nombre = "Caja"
                        },
                        new
                        {
                            Id = 4,
                            Estado = true,
                            FechaCreacion = new DateTime(2024, 2, 5, 17, 18, 31, 73, DateTimeKind.Local).AddTicks(1708),
                            Nombre = "Paquete"
                        });
                });

            modelBuilder.Entity("RestauranteApp.Entities.DetalleMovimiento", b =>
                {
                    b.HasOne("RestauranteApp.Entities.Movimiento", "Movimiento")
                        .WithMany()
                        .HasForeignKey("MovimientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteApp.Entities.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movimiento");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("RestauranteApp.Entities.Movimiento", b =>
                {
                    b.HasOne("RestauranteApp.Entities.Caja", "Caja")
                        .WithMany()
                        .HasForeignKey("CajaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteApp.Entities.TipoPago", "TipoPago")
                        .WithMany()
                        .HasForeignKey("TipoPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caja");

                    b.Navigation("TipoPago");
                });

            modelBuilder.Entity("RestauranteApp.Entities.Producto", b =>
                {
                    b.HasOne("RestauranteApp.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteApp.Entities.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteApp.Entities.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestauranteApp.Entities.UnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marca");

                    b.Navigation("Proveedor");

                    b.Navigation("UnidadMedida");
                });
#pragma warning restore 612, 618
        }
    }
}
