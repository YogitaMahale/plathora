using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class updateinbusinessownertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FridayClose",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FridayOpen",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MondayClose",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MondayOpen",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaturdayClose",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaturdayOpen",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SundayClose",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SundayOpen",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThursdayClose",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThursdayOpen",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TuesdayClose",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TuesdayOpen",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WednesdayClose",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WednesdayOpen",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customerRegistrationid",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customerid",
                table: "BusinessOwnerRegi",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessOwnerRegi_customerRegistrationid",
                table: "BusinessOwnerRegi",
                column: "customerRegistrationid");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessOwnerRegi_CustomerRegistration_customerRegistrationid",
                table: "BusinessOwnerRegi",
                column: "customerRegistrationid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessOwnerRegi_CustomerRegistration_customerRegistrationid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropIndex(
                name: "IX_BusinessOwnerRegi_customerRegistrationid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "FridayClose",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "FridayOpen",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "MondayClose",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "MondayOpen",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "SaturdayClose",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "SaturdayOpen",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "SundayClose",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "SundayOpen",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "ThursdayClose",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "ThursdayOpen",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "TuesdayClose",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "TuesdayOpen",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "WednesdayClose",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "WednesdayOpen",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "customerRegistrationid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "customerid",
                table: "BusinessOwnerRegi");
        }
    }
}
