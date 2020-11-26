using Microsoft.EntityFrameworkCore.Migrations;

namespace EBookLibrary.Entity.Migrations
{
    public partial class NrOfCopies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCopies",
                table: "LibraryAssets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfCopies",
                table: "LibraryAssets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
