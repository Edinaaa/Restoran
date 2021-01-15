using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class jm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_JedinicaMjeres_JedinicaMjereId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropIndex(
                name: "IX_StavkaNarudzbes_JedinicaMjereId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropColumn(
                name: "JedinicaMjereId",
                table: "StavkaNarudzbes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JedinicaMjereId",
                table: "StavkaNarudzbes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbes_JedinicaMjereId",
                table: "StavkaNarudzbes",
                column: "JedinicaMjereId");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaNarudzbes_JedinicaMjeres_JedinicaMjereId",
                table: "StavkaNarudzbes",
                column: "JedinicaMjereId",
                principalTable: "JedinicaMjeres",
                principalColumn: "JedinicaMjereId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
