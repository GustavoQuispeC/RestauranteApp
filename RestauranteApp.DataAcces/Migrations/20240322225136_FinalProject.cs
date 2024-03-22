using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteApp.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class FinalProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_TipoCliente_TipoClienteId",
                table: "Cliente");

            migrationBuilder.DropTable(
                name: "TipoCliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_TipoClienteId",
                table: "Cliente");

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 114, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 114, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 114, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 114, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 114, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 114, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 136, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 136, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 136, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 136, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 136, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 137, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 137, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 137, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 137, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 138, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 138, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 138, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 138, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 51, 36, 138, DateTimeKind.Local).AddTicks(758));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCliente", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 899, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 899, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 899, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 899, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 899, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 899, DateTimeKind.Local).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 944, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 944, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 944, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 944, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 944, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 16, 19, 13, 31, 946, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_TipoClienteId",
                table: "Cliente",
                column: "TipoClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_TipoCliente_TipoClienteId",
                table: "Cliente",
                column: "TipoClienteId",
                principalTable: "TipoCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
