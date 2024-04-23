using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassificadosApi.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classificados",
                columns: new[] { "Id", "DataCadastro", "Descricao", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 23, 15, 15, 11, 34, DateTimeKind.Local).AddTicks(4585), "Descricao teste teste teste", "Teste 1" },
                    { 2, new DateTime(2024, 4, 23, 15, 15, 11, 34, DateTimeKind.Local).AddTicks(4597), "teste Descriao", "Teste 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classificados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classificados",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
