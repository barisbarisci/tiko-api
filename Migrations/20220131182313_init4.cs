using Microsoft.EntityFrameworkCore.Migrations;

namespace TikoAPI.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "houses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "EditDate",
                table: "houses",
                newName: "edit_date");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "cities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "cities",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "EditDate",
                table: "cities",
                newName: "edit_date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "agents",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "EditDate",
                table: "agents",
                newName: "edit_date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "houses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "edit_date",
                table: "houses",
                newName: "EditDate");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "cities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "cities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "edit_date",
                table: "cities",
                newName: "EditDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "agents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "edit_date",
                table: "agents",
                newName: "EditDate");
        }
    }
}
