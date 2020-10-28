using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addadvertisementtesttable11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "advertisementtest",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerid = table.Column<int>(nullable: false),
                    agentid = table.Column<int>(nullable: true),
                    adviceid = table.Column<int>(nullable: false),
                    startdate = table.Column<DateTime>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    shortdesc = table.Column<string>(nullable: true),
                    longdesc = table.Column<string>(nullable: true),
                    img1 = table.Column<string>(nullable: true),
                    img2 = table.Column<string>(nullable: true),
                    isdeleted = table.Column<bool>(nullable: false),
                    isactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisementtest", x => x.id);
                    table.ForeignKey(
                        name: "FK_advertisementtest_Advertise_adviceid",
                        column: x => x.adviceid,
                        principalTable: "Advertise",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_advertisementtest_affiltateRegistrations_agentid",
                        column: x => x.agentid,
                        principalTable: "affiltateRegistrations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_advertisementtest_CustomerRegistration_customerid",
                        column: x => x.customerid,
                        principalTable: "CustomerRegistration",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_advertisementtest_adviceid",
                table: "advertisementtest",
                column: "adviceid");

            migrationBuilder.CreateIndex(
                name: "IX_advertisementtest_agentid",
                table: "advertisementtest",
                column: "agentid");

            migrationBuilder.CreateIndex(
                name: "IX_advertisementtest_customerid",
                table: "advertisementtest",
                column: "customerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertisementtest");
        }
    }
}
