using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addsocialDetailstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikeCnt",
                table: "socials");

            migrationBuilder.DropColumn(
                name: "comment",
                table: "socials");

            migrationBuilder.DropColumn(
                name: "disLikeCnt",
                table: "socials");

            migrationBuilder.CreateTable(
                name: "socialdetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    socialid = table.Column<int>(nullable: false),
                    customerid = table.Column<int>(nullable: false),
                    LikeCnt = table.Column<int>(nullable: false),
                    comment = table.Column<string>(nullable: true),
                    isdeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialdetails", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "socialdetails");

            migrationBuilder.AddColumn<int>(
                name: "LikeCnt",
                table: "socials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "comment",
                table: "socials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "disLikeCnt",
                table: "socials",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
