using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EBookLibrary.Entity.Migrations
{
    public partial class checkout2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckOuts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibraryAssetId = table.Column<int>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Sine = table.Column<DateTime>(nullable: false),
                    until = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckOuts", x => x.id);
                    table.ForeignKey(
                        name: "FK_CheckOuts_LibraryAssets_LibraryAssetId",
                        column: x => x.LibraryAssetId,
                        principalTable: "LibraryAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckOuts_LibraryAssetId",
                table: "CheckOuts",
                column: "LibraryAssetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckOuts");
        }
    }
}
