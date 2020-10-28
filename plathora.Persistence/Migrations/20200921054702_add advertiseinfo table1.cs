using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addadvertiseinfotable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_advertisementInfos_affiltateRegistrations_affiltateRegistrationid",
                table: "advertisementInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_advertisementInfos_CustomerRegistration_customerRegistrationid",
                table: "advertisementInfos");

            migrationBuilder.DropIndex(
                name: "IX_advertisementInfos_affiltateRegistrationid",
                table: "advertisementInfos");

            migrationBuilder.DropIndex(
                name: "IX_advertisementInfos_customerRegistrationid",
                table: "advertisementInfos");

            migrationBuilder.DropColumn(
                name: "affiltateRegistrationid",
                table: "advertisementInfos");

            migrationBuilder.DropColumn(
                name: "customerRegistrationid",
                table: "advertisementInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "affiltateRegistrationid",
                table: "advertisementInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "customerRegistrationid",
                table: "advertisementInfos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_advertisementInfos_affiltateRegistrationid",
                table: "advertisementInfos",
                column: "affiltateRegistrationid");

            migrationBuilder.CreateIndex(
                name: "IX_advertisementInfos_customerRegistrationid",
                table: "advertisementInfos",
                column: "customerRegistrationid");

            migrationBuilder.AddForeignKey(
                name: "FK_advertisementInfos_affiltateRegistrations_affiltateRegistrationid",
                table: "advertisementInfos",
                column: "affiltateRegistrationid",
                principalTable: "affiltateRegistrations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_advertisementInfos_CustomerRegistration_customerRegistrationid",
                table: "advertisementInfos",
                column: "customerRegistrationid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
