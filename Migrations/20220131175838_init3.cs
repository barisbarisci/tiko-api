using Microsoft.EntityFrameworkCore.Migrations;

namespace TikoAPI.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_City_CityId",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_City_CityId",
                table: "Houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Houses",
                table: "Houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agents",
                table: "Agents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "Houses",
                newName: "houses");

            migrationBuilder.RenameTable(
                name: "Agents",
                newName: "agents");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "cities");

            migrationBuilder.RenameIndex(
                name: "IX_Houses_CityId",
                table: "houses",
                newName: "IX_houses_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Houses_AgentId",
                table: "houses",
                newName: "IX_houses_AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_Agents_CityId",
                table: "agents",
                newName: "IX_agents_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_houses",
                table: "houses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_agents",
                table: "agents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cities",
                table: "cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_agents_cities_CityId",
                table: "agents",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_houses_agents_AgentId",
                table: "houses",
                column: "AgentId",
                principalTable: "agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_houses_cities_CityId",
                table: "houses",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_agents_cities_CityId",
                table: "agents");

            migrationBuilder.DropForeignKey(
                name: "FK_houses_agents_AgentId",
                table: "houses");

            migrationBuilder.DropForeignKey(
                name: "FK_houses_cities_CityId",
                table: "houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_houses",
                table: "houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_agents",
                table: "agents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cities",
                table: "cities");

            migrationBuilder.RenameTable(
                name: "houses",
                newName: "Houses");

            migrationBuilder.RenameTable(
                name: "agents",
                newName: "Agents");

            migrationBuilder.RenameTable(
                name: "cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_houses_CityId",
                table: "Houses",
                newName: "IX_Houses_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_houses_AgentId",
                table: "Houses",
                newName: "IX_Houses_AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_agents_CityId",
                table: "Agents",
                newName: "IX_Agents_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Houses",
                table: "Houses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agents",
                table: "Agents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_City_CityId",
                table: "Agents",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_City_CityId",
                table: "Houses",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
