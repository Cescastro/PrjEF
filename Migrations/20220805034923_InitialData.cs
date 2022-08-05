using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrjEF.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Categoria_CaregoriaId",
                table: "Tarea");

            migrationBuilder.RenameColumn(
                name: "CaregoriaId",
                table: "Tarea",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_CaregoriaId",
                table: "Tarea",
                newName: "IX_Tarea_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "UserNameCreacion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86adc"), null, "Actividades Pendientes", 20 });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86aec"), null, "Actividades Personales", 50 });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo", "UserNameCreacion" },
                values: new object[] { new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86aaa"), new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86adc"), null, new DateTime(2022, 8, 4, 22, 49, 22, 805, DateTimeKind.Local).AddTicks(2299), 1, "Pago Servicios", null });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo", "UserNameCreacion" },
                values: new object[] { new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86bbb"), new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86aec"), null, new DateTime(2022, 8, 4, 22, 49, 22, 805, DateTimeKind.Local).AddTicks(2320), 2, "Ver Serie Netflix", null });

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Categoria_CategoriaId",
                table: "Tarea",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarea_Categoria_CategoriaId",
                table: "Tarea");

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86aaa"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86bbb"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86adc"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("968d0c48-bfc4-4d6b-8776-38f06bf86aec"));

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Tarea",
                newName: "CaregoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Tarea_CategoriaId",
                table: "Tarea",
                newName: "IX_Tarea_CaregoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "UserNameCreacion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tarea_Categoria_CaregoriaId",
                table: "Tarea",
                column: "CaregoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
