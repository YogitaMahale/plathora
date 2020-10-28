using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addimagescolimninslider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "sliderimg1",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sliderimg2",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sliderimg3",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sliderimg4",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sliderimg5",
                table: "BusinessOwnerRegi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sliderimg1",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "sliderimg2",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "sliderimg3",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "sliderimg4",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "sliderimg5",
                table: "BusinessOwnerRegi");
        }
    }
}
