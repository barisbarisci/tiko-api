using Microsoft.EntityFrameworkCore.Migrations;

namespace TikoAPI.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_houses_agents_AgentId",
                table: "houses");

            migrationBuilder.DropForeignKey(
                name: "FK_houses_cities_CityId",
                table: "houses");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "houses",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "houses",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "houses",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "houses",
                newName: "city_id");

            migrationBuilder.RenameColumn(
                name: "BedroomCount",
                table: "houses",
                newName: "bedroom_count");

            migrationBuilder.RenameColumn(
                name: "AgentId",
                table: "houses",
                newName: "agent_id");

            migrationBuilder.RenameIndex(
                name: "IX_houses_CityId",
                table: "houses",
                newName: "IX_houses_city_id");

            migrationBuilder.RenameIndex(
                name: "IX_houses_AgentId",
                table: "houses",
                newName: "IX_houses_agent_id");

            migrationBuilder.AddForeignKey(
                name: "FK_houses_agents_agent_id",
                table: "houses",
                column: "agent_id",
                principalTable: "agents",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_houses_cities_city_id",
                table: "houses",
                column: "city_id",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_houses_agents_agent_id",
                table: "houses");

            migrationBuilder.DropForeignKey(
                name: "FK_houses_cities_city_id",
                table: "houses");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "houses",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "houses",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "houses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "city_id",
                table: "houses",
                newName: "CityId");

            migrationBuilder.RenameColumn(
                name: "bedroom_count",
                table: "houses",
                newName: "BedroomCount");

            migrationBuilder.RenameColumn(
                name: "agent_id",
                table: "houses",
                newName: "AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_houses_city_id",
                table: "houses",
                newName: "IX_houses_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_houses_agent_id",
                table: "houses",
                newName: "IX_houses_AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_houses_agents_AgentId",
                table: "houses",
                column: "AgentId",
                principalTable: "agents",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_houses_cities_CityId",
                table: "houses",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
