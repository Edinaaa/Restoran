using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class narudzbakid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzbas_Korisniks_KorisnikId",
                table: "Narudzbas");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeZahtjevas_Korisniks_KorisnikId",
                table: "StavkeZahtjevas");

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "StavkeZahtjevas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Narudzbas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzbas_Korisniks_KorisnikId",
                table: "Narudzbas",
                column: "KorisnikId",
                principalTable: "Korisniks",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeZahtjevas_Korisniks_KorisnikId",
                table: "StavkeZahtjevas",
                column: "KorisnikId",
                principalTable: "Korisniks",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzbas_Korisniks_KorisnikId",
                table: "Narudzbas");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeZahtjevas_Korisniks_KorisnikId",
                table: "StavkeZahtjevas");

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "StavkeZahtjevas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Narudzbas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzbas_Korisniks_KorisnikId",
                table: "Narudzbas",
                column: "KorisnikId",
                principalTable: "Korisniks",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeZahtjevas_Korisniks_KorisnikId",
                table: "StavkeZahtjevas",
                column: "KorisnikId",
                principalTable: "Korisniks",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
