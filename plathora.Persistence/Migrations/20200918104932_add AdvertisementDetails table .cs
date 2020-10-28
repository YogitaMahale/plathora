using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addAdvertisementDetailstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "advertisementDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    affilateid = table.Column<int>(nullable: true),
                    customerId = table.Column<int>(nullable: false),
                    Advertiseid = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_advertisementDetails", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertisementDetails");
        }
    }
}
