using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addAdvertiseDetailstablenew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertisements");

            migrationBuilder.CreateTable(
                name: "advertiseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_advertiseDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_advertiseDetails_Advertise_Advertiseid",
                        column: x => x.Advertiseid,
                        principalTable: "Advertise",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_advertiseDetails_affiltateRegistrations_affilateid",
                        column: x => x.affilateid,
                        principalTable: "affiltateRegistrations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_advertiseDetails_CustomerRegistration_customerId",
                        column: x => x.customerId,
                        principalTable: "CustomerRegistration",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_advertiseDetails_Advertiseid",
                table: "advertiseDetails",
                column: "Advertiseid");

            migrationBuilder.CreateIndex(
                name: "IX_advertiseDetails_affilateid",
                table: "advertiseDetails",
                column: "affilateid");

            migrationBuilder.CreateIndex(
                name: "IX_advertiseDetails_customerId",
                table: "advertiseDetails",
                column: "customerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertiseDetails");

            migrationBuilder.CreateTable(
                name: "advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    advertisetype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false),
                    longdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    videourl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisements", x => x.Id);
                });
        }
    }
}
