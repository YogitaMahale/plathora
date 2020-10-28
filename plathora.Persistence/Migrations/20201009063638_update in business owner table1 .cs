using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class updateinbusinessownertable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessOwnerRegi_CustomerRegistration_customerRegistrationid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropIndex(
                name: "IX_BusinessOwnerRegi_customerRegistrationid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "customerRegistrationid",
                table: "BusinessOwnerRegi");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessOwnerRegi_customerid",
                table: "BusinessOwnerRegi",
                column: "customerid");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessOwnerRegi_CustomerRegistration_customerid",
                table: "BusinessOwnerRegi",
                column: "customerid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessOwnerRegi_CustomerRegistration_customerid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropIndex(
                name: "IX_BusinessOwnerRegi_customerid",
                table: "BusinessOwnerRegi");

            migrationBuilder.AddColumn<int>(
                name: "customerRegistrationid",
                table: "BusinessOwnerRegi",
                type: "int",
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
    }
}
