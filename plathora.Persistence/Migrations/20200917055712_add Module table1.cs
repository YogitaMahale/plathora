using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addModuletable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.CreateTable(
                name: "moduleMasters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    commissionper = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    isdeleted = table.Column<bool>(nullable: false),
                    isactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moduleMasters", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "moduleMasters");

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commissionper = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false),
                    isdeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.id);
                });
        }
    }
}
