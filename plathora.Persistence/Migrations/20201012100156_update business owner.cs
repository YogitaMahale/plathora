using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class updatebusinessowner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessOwnerRegi_ProductMaster_productid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropIndex(
                name: "IX_BusinessOwnerRegi_productid",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "BusinessIdList",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "productidList",
                table: "BusinessOwnerRegi");

            migrationBuilder.AlterColumn<string>(
                name: "productid",
                table: "BusinessOwnerRegi",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "businessid",
                table: "BusinessOwnerRegi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "businessid",
                table: "BusinessOwnerRegi");

            migrationBuilder.AlterColumn<int>(
                name: "productid",
                table: "BusinessOwnerRegi",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessIdList",
                table: "BusinessOwnerRegi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "productidList",
                table: "BusinessOwnerRegi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessOwnerRegi_productid",
                table: "BusinessOwnerRegi",
                column: "productid");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessOwnerRegi_ProductMaster_productid",
                table: "BusinessOwnerRegi",
                column: "productid",
                principalTable: "ProductMaster",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
