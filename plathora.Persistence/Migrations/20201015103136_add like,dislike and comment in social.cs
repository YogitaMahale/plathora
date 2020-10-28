using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addlikedislikeandcommentinsocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LikeCnt",
                table: "socials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "comment",
                table: "socials",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "disLikeCnt",
                table: "socials",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
