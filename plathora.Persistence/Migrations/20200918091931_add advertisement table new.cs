using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addadvertisementtablenew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(nullable: true),
                    advertisetype = table.Column<string>(nullable: true),
                    startdate = table.Column<DateTime>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    videourl = table.Column<string>(nullable: true),
                    shortdesc = table.Column<string>(nullable: true),
                    longdesc = table.Column<string>(nullable: true),
                    img1 = table.Column<string>(nullable: true),
                    img2 = table.Column<string>(nullable: true),
                    isdeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisements", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertisements");
        }
    }
}
