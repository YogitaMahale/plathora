using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertiseDetails");

            migrationBuilder.DropTable(
                name: "advertisementDetails");

            migrationBuilder.DropTable(
                name: "advertisementtest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "advertiseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Advertiseid = table.Column<int>(type: "int", nullable: false),
                    affilateid = table.Column<int>(type: "int", nullable: true),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false),
                    longdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    videourl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertiseDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "advertisementDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Advertiseid = table.Column<int>(type: "int", nullable: false),
                    affilateid = table.Column<int>(type: "int", nullable: true),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false),
                    longdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    videourl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisementDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "advertisementtest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adviceid = table.Column<int>(type: "int", nullable: false),
                    agentid = table.Column<int>(type: "int", nullable: true),
                    customerid = table.Column<int>(type: "int", nullable: false),
                    img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isactive = table.Column<bool>(type: "bit", nullable: false),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false),
                    longdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisementtest", x => x.id);
                });
        }
    }
}
