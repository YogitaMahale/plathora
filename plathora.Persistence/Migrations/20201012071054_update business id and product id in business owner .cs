using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class updatebusinessidandproductidinbusinessowner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BusinessIdList",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "productidList",
                table: "BusinessOwnerRegi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessIdList",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "productidList",
                table: "BusinessOwnerRegi");
        }
    }
}
