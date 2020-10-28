using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addvideotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "videos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fkmoduleid = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    videoName = table.Column<string>(nullable: true),
                    videoLink = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    isdeleted = table.Column<bool>(nullable: false),
                    isactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videos", x => x.id);
                    table.ForeignKey(
                        name: "FK_videos_moduleMasters_fkmoduleid",
                        column: x => x.fkmoduleid,
                        principalTable: "moduleMasters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_videos_fkmoduleid",
                table: "videos",
                column: "fkmoduleid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "videos");
        }
    }
}
