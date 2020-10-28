using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addimginAdvertise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "Advertise",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img",
                table: "Advertise");
        }
    }
}
