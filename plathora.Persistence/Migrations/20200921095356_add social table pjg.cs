using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addsocialtablepjg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_socials_customerid",
                table: "socials",
                column: "customerid");

            migrationBuilder.AddForeignKey(
                name: "FK_socials_CustomerRegistration_customerid",
                table: "socials",
                column: "customerid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_socials_CustomerRegistration_customerid",
                table: "socials");

            migrationBuilder.DropIndex(
                name: "IX_socials_customerid",
                table: "socials");

            migrationBuilder.AddColumn<int>(
                name: "customerRegistrationid",
                table: "socials",
                type: "int",
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
    }
}
