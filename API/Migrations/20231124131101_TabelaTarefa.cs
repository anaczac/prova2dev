using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class TabelaTarefa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 25, 10, 11, 1, 175, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 26, 10, 11, 1, 175, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 10, 11, 1, 175, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 1, 10, 11, 1, 175, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 10, 11, 1, 175, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 8, 10, 11, 1, 175, DateTimeKind.Local).AddTicks(3066));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 25, 10, 10, 42, 892, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 26, 10, 10, 42, 892, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 10, 10, 42, 892, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 1, 10, 10, 42, 892, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 10, 10, 42, 892, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 8, 10, 10, 42, 892, DateTimeKind.Local).AddTicks(4803));
        }
    }
}
