using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addadvertiseinfotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "advertisementInfos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    affilateid = table.Column<int>(nullable: true),
                    affiltateRegistrationid = table.Column<int>(nullable: true),
                    cusotmerid = table.Column<int>(nullable: false),
                    customerRegistrationid = table.Column<int>(nullable: true),
                    advertiseid = table.Column<int>(nullable: false),
                    startdate = table.Column<DateTime>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    videourl = table.Column<string>(nullable: true),
                    shortdesc = table.Column<string>(nullable: true),
                    longdesc = table.Column<string>(nullable: true),
                    image1 = table.Column<string>(nullable: true),
                    image2 = table.Column<string>(nullable: true),
                    isdeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advertisementInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_advertisementInfos_Advertise_advertiseid",
                        column: x => x.advertiseid,
                        principalTable: "Advertise",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_advertisementInfos_affiltateRegistrations_affiltateRegistrationid",
                        column: x => x.affiltateRegistrationid,
                        principalTable: "affiltateRegistrations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_advertisementInfos_CustomerRegistration_customerRegistrationid",
                        column: x => x.customerRegistrationid,
                        principalTable: "CustomerRegistration",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_advertisementInfos_advertiseid",
                table: "advertisementInfos",
                column: "advertiseid");

            migrationBuilder.CreateIndex(
                name: "IX_advertisementInfos_affiltateRegistrationid",
                table: "advertisementInfos",
                column: "affiltateRegistrationid");

            migrationBuilder.CreateIndex(
                name: "IX_advertisementInfos_customerRegistrationid",
                table: "advertisementInfos",
                column: "customerRegistrationid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertisementInfos");
        }
    }
}
