using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrjEF.Migrations
{
    public partial class TareaColumnUserNameCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserNameCreacion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNameCreacion",
                table: "Tarea");
        }
    }
}
