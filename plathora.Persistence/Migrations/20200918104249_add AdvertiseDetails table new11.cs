using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addAdvertiseDetailstablenew11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_advertiseDetails_Advertise_Advertiseid",
                table: "advertiseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_advertiseDetails_affiltateRegistrations_affilateid",
                table: "advertiseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_advertiseDetails_CustomerRegistration_customerRegistrationid",
                table: "advertiseDetails");

            migrationBuilder.DropIndex(
                name: "IX_advertiseDetails_Advertiseid",
                table: "advertiseDetails");

            migrationBuilder.DropIndex(
                name: "IX_advertiseDetails_affilateid",
                table: "advertiseDetails");

            migrationBuilder.DropIndex(
                name: "IX_advertiseDetails_customerRegistrationid",
                table: "advertiseDetails");

            migrationBuilder.DropColumn(
                name: "customerRegistrationid",
                table: "advertiseDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customerRegistrationid",
                table: "advertiseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_advertiseDetails_Advertiseid",
                table: "advertiseDetails",
                column: "Advertiseid");

            migrationBuilder.CreateIndex(
                name: "IX_advertiseDetails_affilateid",
                table: "advertiseDetails",
                column: "affilateid");

            migrationBuilder.CreateIndex(
                name: "IX_advertiseDetails_customerRegistrationid",
                table: "advertiseDetails",
                column: "customerRegistrationid");

            migrationBuilder.AddForeignKey(
                name: "FK_advertiseDetails_Advertise_Advertiseid",
                table: "advertiseDetails",
                column: "Advertiseid",
                principalTable: "Advertise",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_advertiseDetails_affiltateRegistrations_affilateid",
                table: "advertiseDetails",
                column: "affilateid",
                principalTable: "affiltateRegistrations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_advertiseDetails_CustomerRegistration_customerRegistrationid",
                table: "advertiseDetails",
                column: "customerRegistrationid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
