using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

//#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestauranteApp.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracionDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaldoInicial = table.Column<float>(type: "real", nullable: false),
                    FechaApertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaCierre = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalRecaudado = table.Column<float>(type: "real", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadMedida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadMedida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    Descuento = table.Column<float>(type: "real", nullable: false),
                    MontoFinal = table.Column<float>(type: "real", nullable: false),
                    PagoRecibido = table.Column<float>(type: "real", nullable: false),
                    PagoVuelto = table.Column<float>(type: "real", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CajaId = table.Column<int>(type: "int", nullable: false),
                    TipoPagoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimiento_Caja_CajaId",
                        column: x => x.CajaId,
                        principalTable: "Caja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movimiento_TipoPago_TipoPagoId",
                        column: x => x.TipoPagoId,
                        principalTable: "TipoPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrecioVenta = table.Column<float>(type: "real", nullable: false),
                    PrecioCompra = table.Column<float>(type: "real", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "DATE", nullable: true),
                    UrlImagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: false),
                    UnidadMedidaId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producto_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producto_Proveedor_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producto_UnidadMedida_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "UnidadMedida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleMovimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<float>(type: "real", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    MovimientoId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleMovimiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleMovimiento_Movimiento_MovimientoId",
                        column: x => x.MovimientoId,
                        principalTable: "Movimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleMovimiento_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Estado", "FechaCreacion", "Nombre", "Observacion" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6010), "Parrilla", "" },
                    { 2, true, new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6031), "Hamburguesa", "" },
                    { 3, true, new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6035), "Gaseosa", "" },
                    { 4, true, new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6037), "Cerveza", "" },
                    { 5, true, new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6039), "Wisky", "" },
                    { 6, true, new DateTime(2024, 2, 5, 17, 18, 31, 47, DateTimeKind.Local).AddTicks(6044), "Pisco", "" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Estado", "FechaCreacion", "Nombre", "Observacion" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5584), "Inka Kola", "" },
                    { 2, true, new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5613), "Coca Cola", "" },
                    { 3, true, new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5615), "Queirolo", "" },
                    { 4, true, new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5618), "Tabernero", "" },
                    { 5, true, new DateTime(2024, 2, 5, 17, 18, 31, 68, DateTimeKind.Local).AddTicks(5620), "Pilsen", "" }
                });

            migrationBuilder.InsertData(
                table: "TipoPago",
                columns: new[] { "Id", "Estado", "FechaCreacion", "Nombre", "Observacion" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 2, 5, 17, 18, 31, 72, DateTimeKind.Local).AddTicks(8977), "Efectivo", "" },
                    { 2, true, new DateTime(2024, 2, 5, 17, 18, 31, 72, DateTimeKind.Local).AddTicks(9004), "Transferencia", "" },
                    { 3, true, new DateTime(2024, 2, 5, 17, 18, 31, 72, DateTimeKind.Local).AddTicks(9007), "Yape", "" },
                    { 4, true, new DateTime(2024, 2, 5, 17, 18, 31, 72, DateTimeKind.Local).AddTicks(9009), "Plin", "" }
                });

            migrationBuilder.InsertData(
                table: "UnidadMedida",
                columns: new[] { "Id", "Estado", "FechaCreacion", "Nombre" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 2, 5, 17, 18, 31, 73, DateTimeKind.Local).AddTicks(1689), "Unidad" },
                    { 2, true, new DateTime(2024, 2, 5, 17, 18, 31, 73, DateTimeKind.Local).AddTicks(1703), "Litro" },
                    { 3, true, new DateTime(2024, 2, 5, 17, 18, 31, 73, DateTimeKind.Local).AddTicks(1706), "Caja" },
                    { 4, true, new DateTime(2024, 2, 5, 17, 18, 31, 73, DateTimeKind.Local).AddTicks(1708), "Paquete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMovimiento_MovimientoId",
                table: "DetalleMovimiento",
                column: "MovimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMovimiento_ProductoId",
                table: "DetalleMovimiento",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_CajaId",
                table: "Movimiento",
                column: "CajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_TipoPagoId",
                table: "Movimiento",
                column: "TipoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_MarcaId",
                table: "Producto",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ProveedorId",
                table: "Producto",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_UnidadMedidaId",
                table: "Producto",
                column: "UnidadMedidaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleMovimiento");

            migrationBuilder.DropTable(
                name: "Movimiento");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Caja");

            migrationBuilder.DropTable(
                name: "TipoPago");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "UnidadMedida");
        }
    }
}
