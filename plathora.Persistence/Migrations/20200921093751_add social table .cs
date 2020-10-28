using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addsocialtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "socials",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerid = table.Column<int>(nullable: false),
                    CustomerRegistrationid = table.Column<int>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    isdeleted = table.Column<bool>(nullable: false),
                    isactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socials", x => x.id);
                    table.ForeignKey(
                        name: "FK_socials_CustomerRegistration_CustomerRegistrationid",
                        column: x => x.CustomerRegistrationid,
                        principalTable: "CustomerRegistration",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_socials_CustomerRegistrationid",
                table: "socials",
                column: "CustomerRegistrationid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "socials");
        }
    }
}
