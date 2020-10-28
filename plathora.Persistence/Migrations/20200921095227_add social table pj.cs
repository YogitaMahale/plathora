using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addsocialtablepj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customerRegistrationid",
                table: "socials",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_socials_customerRegistrationid",
                table: "socials",
                column: "customerRegistrationid");

            migrationBuilder.AddForeignKey(
                name: "FK_socials_CustomerRegistration_customerRegistrationid",
                table: "socials",
                column: "customerRegistrationid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_socials_CustomerRegistration_customerRegistrationid",
                table: "socials");

            migrationBuilder.DropIndex(
                name: "IX_socials_customerRegistrationid",
                table: "socials");

            migrationBuilder.DropColumn(
                name: "customerRegistrationid",
                table: "socials");
        }
    }
}
