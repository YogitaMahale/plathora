using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addregisterbyAffilateIDanddeviceidcolumninbusinessownerregi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "deviceid",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "registerbyAffilateID",
                table: "BusinessOwnerRegi",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deviceid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "registerbyAffilateID",
                table: "BusinessOwnerRegi");
        }
    }
}
