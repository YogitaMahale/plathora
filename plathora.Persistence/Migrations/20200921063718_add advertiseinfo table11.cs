using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addadvertiseinfotable11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_advertisementInfos_Advertise_advertiseid",
                table: "advertisementInfos");

            migrationBuilder.DropIndex(
                name: "IX_advertisementInfos_advertiseid",
                table: "advertisementInfos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_advertisementInfos_advertiseid",
                table: "advertisementInfos",
                column: "advertiseid");

            migrationBuilder.AddForeignKey(
                name: "FK_advertisementInfos_Advertise_advertiseid",
                table: "advertisementInfos",
                column: "advertiseid",
                principalTable: "Advertise",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
