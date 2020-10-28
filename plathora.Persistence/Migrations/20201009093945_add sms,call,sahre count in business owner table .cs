using Microsoft.EntityFrameworkCore.Migrations;

namespace plathora.Persistence.Migrations
{
    public partial class addsmscallsahrecountinbusinessownertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CallCount",
                table: "BusinessOwnerRegi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SMSCount",
                table: "BusinessOwnerRegi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShareCount",
                table: "BusinessOwnerRegi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WhatssappCount",
                table: "BusinessOwnerRegi",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CallCount",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "SMSCount",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "ShareCount",
                table: "BusinessOwnerRegi");

            migrationBuilder.DropColumn(
                name: "WhatssappCount",
                table: "BusinessOwnerRegi");
        }
    }
}
