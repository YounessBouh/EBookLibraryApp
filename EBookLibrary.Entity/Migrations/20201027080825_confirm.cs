using Microsoft.EntityFrameworkCore.Migrations;

namespace EBookLibrary.Entity.Migrations
{
    public partial class confirm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirm",
                table: "CheckOuts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirm",
                table: "CheckOuts");
        }
    }
}
