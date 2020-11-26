using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EBookLibrary.Entity.Migrations
{
    public partial class checkout3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sine",
                table: "CheckOuts");

            migrationBuilder.RenameColumn(
                name: "until",
                table: "CheckOuts",
                newName: "Until");

            migrationBuilder.AddColumn<DateTime>(
                name: "Since",
                table: "CheckOuts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Since",
                table: "CheckOuts");

            migrationBuilder.RenameColumn(
                name: "Until",
                table: "CheckOuts",
                newName: "until");

            migrationBuilder.AddColumn<DateTime>(
                name: "Sine",
                table: "CheckOuts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
