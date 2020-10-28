using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addsocialtablep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_socials_CustomerRegistration_CustomerRegistrationid",
                table: "socials");

            migrationBuilder.DropIndex(
                name: "IX_socials_CustomerRegistrationid",
                table: "socials");

            migrationBuilder.DropColumn(
                name: "CustomerRegistrationid",
                table: "socials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerRegistrationid",
                table: "socials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_socials_CustomerRegistrationid",
                table: "socials",
                column: "CustomerRegistrationid");

            migrationBuilder.AddForeignKey(
                name: "FK_socials_CustomerRegistration_CustomerRegistrationid",
                table: "socials",
                column: "CustomerRegistrationid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
