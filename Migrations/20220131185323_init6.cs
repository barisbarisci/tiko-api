using Microsoft.EntityFrameworkCore.Migrations;

namespace TikoAPI.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_agents_cities_CityId",
                table: "agents");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "agents",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "agents",
                newName: "city_id");

            migrationBuilder.RenameIndex(
                name: "IX_agents_CityId",
                table: "agents",
                newName: "IX_agents_city_id");

            migrationBuilder.AddForeignKey(
                name: "FK_agents_cities_city_id",
                table: "agents",
                column: "city_id",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_agents_cities_city_id",
                table: "agents");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "agents",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "city_id",
                table: "agents",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_agents_city_id",
                table: "agents",
                newName: "IX_agents_CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_agents_cities_CityId",
                table: "agents",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
