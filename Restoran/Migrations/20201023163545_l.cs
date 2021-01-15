using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropColumn(
                name: "ArtikaId",
                table: "StavkaNarudzbes");

            migrationBuilder.AlterColumn<int>(
                name: "ArtikalId",
                table: "StavkaNarudzbes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.AlterColumn<int>(
                name: "ArtikalId",
                table: "StavkaNarudzbes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ArtikaId",
                table: "StavkaNarudzbes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
