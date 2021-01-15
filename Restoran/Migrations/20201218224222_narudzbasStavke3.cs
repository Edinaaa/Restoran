using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class narudzbasStavke3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropIndex(
                name: "IX_StavkaNarudzbes_ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropColumn(
                name: "ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.AddColumn<int>(
                name: "StavkeMeniaId",
                table: "StavkaNarudzbes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbes_StavkeMeniaId",
                table: "StavkaNarudzbes",
                column: "StavkeMeniaId");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaNarudzbes_StavkeMenias_StavkeMeniaId",
                table: "StavkaNarudzbes",
                column: "StavkeMeniaId",
                principalTable: "StavkeMenias",
                principalColumn: "StavkeMeniaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_StavkeMenias_StavkeMeniaId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropIndex(
                name: "IX_StavkaNarudzbes_StavkeMeniaId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropColumn(
                name: "StavkeMeniaId",
                table: "StavkaNarudzbes");

            migrationBuilder.AddColumn<int>(
                name: "ArtikalId",
                table: "StavkaNarudzbes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbes_ArtikalId",
                table: "StavkaNarudzbes",
                column: "ArtikalId");

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
