using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addadvertisementtesttable1lknew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_advertisementtest_Advertise_adviceid",
                table: "advertisementtest");

            migrationBuilder.DropForeignKey(
                name: "FK_advertisementtest_affiltateRegistrations_agentid",
                table: "advertisementtest");

            migrationBuilder.DropForeignKey(
                name: "FK_advertisementtest_CustomerRegistration_customerid",
                table: "advertisementtest");

            migrationBuilder.DropIndex(
                name: "IX_advertisementtest_adviceid",
                table: "advertisementtest");

            migrationBuilder.DropIndex(
                name: "IX_advertisementtest_agentid",
                table: "advertisementtest");

            migrationBuilder.DropIndex(
                name: "IX_advertisementtest_customerid",
                table: "advertisementtest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_advertisementtest_adviceid",
                table: "advertisementtest",
                column: "adviceid");

            migrationBuilder.CreateIndex(
                name: "IX_advertisementtest_agentid",
                table: "advertisementtest",
                column: "agentid");

            migrationBuilder.CreateIndex(
                name: "IX_advertisementtest_customerid",
                table: "advertisementtest",
                column: "customerid");

            migrationBuilder.AddForeignKey(
                name: "FK_advertisementtest_Advertise_adviceid",
                table: "advertisementtest",
                column: "adviceid",
                principalTable: "Advertise",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_advertisementtest_affiltateRegistrations_agentid",
                table: "advertisementtest",
                column: "agentid",
                principalTable: "affiltateRegistrations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_advertisementtest_CustomerRegistration_customerid",
                table: "advertisementtest",
                column: "customerid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
