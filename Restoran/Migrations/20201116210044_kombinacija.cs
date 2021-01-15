using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class kombinacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Kategorija_KategorijaId",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK_Kombinacija_Ponudas_PonudaId",
                table: "Kombinacija");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeKombinacijes_JedinicaMjeres_JedinicaMjereId",
                table: "StavkeKombinacijes");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeKombinacijes_Kombinacija_KombinacijaId",
                table: "StavkeKombinacijes");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeMenias_Kategorija_KategorijaId",
                table: "StavkeMenias");

            migrationBuilder.DropIndex(
                name: "IX_StavkeKombinacijes_JedinicaMjereId",
                table: "StavkeKombinacijes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kombinacija",
                table: "Kombinacija");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategorija",
                table: "Kategorija");

            migrationBuilder.DropColumn(
                name: "JedinicaMjereId",
                table: "StavkeKombinacijes");

            migrationBuilder.RenameTable(
                name: "Kombinacija",
                newName: "Kombinacijas");

            migrationBuilder.RenameTable(
                name: "Kategorija",
                newName: "Kategorijas");

            migrationBuilder.RenameIndex(
                name: "IX_Kombinacija_PonudaId",
                table: "Kombinacijas",
                newName: "IX_Kombinacijas_PonudaId");

            migrationBuilder.AlterColumn<int>(
                name: "ArtikalId",
                table: "StavkaNarudzbes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KombinacijaId",
                table: "StavkaNarudzbes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PDV",
                table: "Kombinacijas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Slika",
                table: "Kombinacijas",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kombinacijas",
                table: "Kombinacijas",
                column: "KombinacijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategorijas",
                table: "Kategorijas",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbes_KombinacijaId",
                table: "StavkaNarudzbes",
                column: "KombinacijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Kategorijas_KategorijaId",
                table: "Artikli",
                column: "KategorijaId",
                principalTable: "Kategorijas",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kombinacijas_Ponudas_PonudaId",
                table: "Kombinacijas",
                column: "PonudaId",
                principalTable: "Ponudas",
                principalColumn: "PonudaId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeKombinacijes_Kombinacijas_KombinacijaId",
                table: "StavkeKombinacijes",
                column: "KombinacijaId",
                principalTable: "Kombinacijas",
                principalColumn: "KombinacijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeMenias_Kategorijas_KategorijaId",
                table: "StavkeMenias",
                column: "KategorijaId",
                principalTable: "Kategorijas",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Kategorijas_KategorijaId",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK_Kombinacijas_Ponudas_PonudaId",
                table: "Kombinacijas");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaNarudzbes_Kombinacijas_KombinacijaId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeKombinacijes_Kombinacijas_KombinacijaId",
                table: "StavkeKombinacijes");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeMenias_Kategorijas_KategorijaId",
                table: "StavkeMenias");

            migrationBuilder.DropIndex(
                name: "IX_StavkaNarudzbes_KombinacijaId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kombinacijas",
                table: "Kombinacijas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategorijas",
                table: "Kategorijas");

            migrationBuilder.DropColumn(
                name: "KombinacijaId",
                table: "StavkaNarudzbes");

            migrationBuilder.DropColumn(
                name: "PDV",
                table: "Kombinacijas");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Kombinacijas");

            migrationBuilder.RenameTable(
                name: "Kombinacijas",
                newName: "Kombinacija");

            migrationBuilder.RenameTable(
                name: "Kategorijas",
                newName: "Kategorija");

            migrationBuilder.RenameIndex(
                name: "IX_Kombinacijas_PonudaId",
                table: "Kombinacija",
                newName: "IX_Kombinacija_PonudaId");

            migrationBuilder.AddColumn<int>(
                name: "JedinicaMjereId",
                table: "StavkeKombinacijes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ArtikalId",
                table: "StavkaNarudzbes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kombinacija",
                table: "Kombinacija",
                column: "KombinacijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategorija",
                table: "Kategorija",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeKombinacijes_JedinicaMjereId",
                table: "StavkeKombinacijes",
                column: "JedinicaMjereId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Kategorija_KategorijaId",
                table: "Artikli",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kombinacija_Ponudas_PonudaId",
                table: "Kombinacija",
                column: "PonudaId",
                principalTable: "Ponudas",
                principalColumn: "PonudaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                table: "StavkaNarudzbes",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeKombinacijes_JedinicaMjeres_JedinicaMjereId",
                table: "StavkeKombinacijes",
                column: "JedinicaMjereId",
                principalTable: "JedinicaMjeres",
                principalColumn: "JedinicaMjereId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeKombinacijes_Kombinacija_KombinacijaId",
                table: "StavkeKombinacijes",
                column: "KombinacijaId",
                principalTable: "Kombinacija",
                principalColumn: "KombinacijaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeMenias_Kategorija_KategorijaId",
                table: "StavkeMenias",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
