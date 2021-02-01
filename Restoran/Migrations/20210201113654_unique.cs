using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class unique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Zahtjevs",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Uloges",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Menis",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Slika",
                table: "Korisniks",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Korisniks",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaSalt",
                table: "Korisniks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaHesh",
                table: "Korisniks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Korisniks",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Slika",
                table: "Kombinacijas",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Kombinacijas",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Kategorijas",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "JedinicaMjeres",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Slika",
                table: "Artikli",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sastav",
                table: "Artikli",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Artikli",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevs_Naziv",
                table: "Zahtjevs",
                column: "Naziv",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uloges_Naziv",
                table: "Uloges",
                column: "Naziv",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Korisniks_KorisnickoIme",
                table: "Korisniks",
                column: "KorisnickoIme",
                unique: true,
                filter: "[KorisnickoIme] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Kategorijas_Naziv",
                table: "Kategorijas",
                column: "Naziv",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JedinicaMjeres_Naziv",
                table: "JedinicaMjeres",
                column: "Naziv",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Zahtjevs_Naziv",
                table: "Zahtjevs");

            migrationBuilder.DropIndex(
                name: "IX_Uloges_Naziv",
                table: "Uloges");

            migrationBuilder.DropIndex(
                name: "IX_Korisniks_KorisnickoIme",
                table: "Korisniks");

            migrationBuilder.DropIndex(
                name: "IX_Kategorijas_Naziv",
                table: "Kategorijas");

            migrationBuilder.DropIndex(
                name: "IX_JedinicaMjeres_Naziv",
                table: "JedinicaMjeres");

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Zahtjevs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Uloges",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Menis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<byte[]>(
                name: "Slika",
                table: "Korisniks",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]));

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Korisniks",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaSalt",
                table: "Korisniks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaHesh",
                table: "Korisniks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Korisniks",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Slika",
                table: "Kombinacijas",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]));

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Kombinacijas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Kategorijas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "JedinicaMjeres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Slika",
                table: "Artikli",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]));

            migrationBuilder.AlterColumn<string>(
                name: "Sastav",
                table: "Artikli",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Artikli",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }
    }
}
