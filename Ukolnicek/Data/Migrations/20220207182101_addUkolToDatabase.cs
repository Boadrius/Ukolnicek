using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ukolnicek.Data.Migrations
{
    public partial class addUkolToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ukoly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazevUkolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DruhPrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CasOd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CasDo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ukoly", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ukoly");
        }
    }
}
