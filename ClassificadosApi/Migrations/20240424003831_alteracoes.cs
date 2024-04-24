using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassificadosApi.Migrations
{
    /// <inheritdoc />
    public partial class alteracoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Classificados",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500);

            migrationBuilder.UpdateData(
                table: "Classificados",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2024, 4, 23, 20, 38, 30, 911, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Classificados",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2024, 4, 23, 20, 38, 30, 911, DateTimeKind.Local).AddTicks(2477));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Classificados",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Classificados",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2024, 4, 23, 20, 37, 26, 979, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Classificados",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2024, 4, 23, 20, 37, 26, 979, DateTimeKind.Local).AddTicks(1145));
        }
    }
}
