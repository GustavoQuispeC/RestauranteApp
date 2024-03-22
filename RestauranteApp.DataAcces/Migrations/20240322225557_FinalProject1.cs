using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteApp.DataAcces.Migrations
{
    /// <inheritdoc />
    public partial class FinalProject1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoClienteId",
                table: "Cliente");

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 548, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 548, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 548, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 548, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 548, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 548, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 571, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 571, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 571, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 571, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 571, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "TipoPago",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "UnidadMedida",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2024, 3, 22, 17, 55, 57, 572, DateTimeKind.Local).AddTicks(2340));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoClienteId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
