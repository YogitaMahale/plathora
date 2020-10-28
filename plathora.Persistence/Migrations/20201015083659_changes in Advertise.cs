using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class changesinAdvertise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertise_affiltateRegistrations_affilateid",
                table: "Advertise");

            migrationBuilder.DropIndex(
                name: "IX_Advertise_affilateid",
                table: "Advertise");

            migrationBuilder.DropColumn(
                name: "affilateid",
                table: "Advertise");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "affilateid",
                table: "Advertise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Advertise_affilateid",
                table: "Advertise",
                column: "affilateid");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertise_affiltateRegistrations_affilateid",
                table: "Advertise",
                column: "affilateid",
                principalTable: "affiltateRegistrations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
