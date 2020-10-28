using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addcustomeridintblfeedbacktable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblfeedback_CustomerRegistration_customerid",
                table: "tblfeedback");

            migrationBuilder.DropIndex(
                name: "IX_tblfeedback_customerid",
                table: "tblfeedback");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tblfeedback_customerid",
                table: "tblfeedback",
                column: "customerid");

            migrationBuilder.AddForeignKey(
                name: "FK_tblfeedback_CustomerRegistration_customerid",
                table: "tblfeedback",
                column: "customerid",
                principalTable: "CustomerRegistration",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
