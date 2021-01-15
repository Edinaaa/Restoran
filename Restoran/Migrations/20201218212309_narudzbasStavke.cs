using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class narudzbasStavke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Kombinacijas_KombinacijaId",
                table: "StavkaNarudzbes");

            migrationBuilder.AlterColumn<int>(
                name: "KombinacijaId",
                table: "StavkaNarudzbes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaNarudzbes_Kombinacijas_KombinacijaId",
                table: "StavkaNarudzbes",
                column: "KombinacijaId",
                principalTable: "Kombinacijas",
                principalColumn: "KombinacijaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Kombinacijas_KombinacijaId",
                table: "StavkaNarudzbes");

            migrationBuilder.AlterColumn<int>(
                name: "KombinacijaId",
                table: "StavkaNarudzbes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ArtikalId",
                table: "StavkaNarudzbes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaNarudzbes_Kombinacijas_KombinacijaId",
                table: "StavkaNarudzbes",
                column: "KombinacijaId",
                principalTable: "Kombinacijas",
                principalColumn: "KombinacijaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
