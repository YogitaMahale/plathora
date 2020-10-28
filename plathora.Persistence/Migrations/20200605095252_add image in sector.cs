using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addimageinsector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "SectorRegistration",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img",
                table: "SectorRegistration");
        }
    }
}
