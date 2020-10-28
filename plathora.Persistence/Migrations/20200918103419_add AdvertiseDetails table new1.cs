using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addAdvertiseDetailstablenew1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_advertiseDetails_CustomerRegistration_customerId",
                table: "advertiseDetails");

            migrationBuilder.DropIndex(
                name: "IX_advertiseDetails_customerId",
                table: "advertiseDetails");

            migrationBuilder.AddColumn<int>(
                name: "customerRegistrationid",
                table: "advertiseDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_advertiseDetails_customerRegistrationid",
                table: "advertiseDetails",
                column: "customerRegistrationid");

            migrationBuilder.AddForeignKey(
                name: "FK_advertiseDetails_CustomerRegistration_customerRegistrationid",
                table: "advertiseDetails",
                column: "customerRegistrationid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_advertiseDetails_CustomerRegistration_customerRegistrationid",
                table: "advertiseDetails");

            migrationBuilder.DropIndex(
                name: "IX_advertiseDetails_customerRegistrationid",
                table: "advertiseDetails");

            migrationBuilder.DropColumn(
                name: "customerRegistrationid",
                table: "advertiseDetails");

            migrationBuilder.CreateIndex(
                name: "IX_advertiseDetails_customerId",
                table: "advertiseDetails",
                column: "customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_advertiseDetails_CustomerRegistration_customerId",
                table: "advertiseDetails",
                column: "customerId",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
