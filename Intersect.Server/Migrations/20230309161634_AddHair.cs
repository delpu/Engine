using Intersect.Enums;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Intersect.Server.Migrations
{
    public partial class AddHair : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomSpriteLayers",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomSpriteLayers",
                table: "Players");

        }
    }
}
