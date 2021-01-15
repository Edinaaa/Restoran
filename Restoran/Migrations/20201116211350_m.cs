﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkeMenias_Kategorijas_KategorijaId",
                table: "StavkeMenias");

            migrationBuilder.DropIndex(
                name: "IX_StavkeMenias_KategorijaId",
                table: "StavkeMenias");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "StavkeMenias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "StavkeMenias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StavkeMenias_KategorijaId",
                table: "StavkeMenias",
                column: "KategorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeMenias_Kategorijas_KategorijaId",
                table: "StavkeMenias",
                column: "KategorijaId",
                principalTable: "Kategorijas",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
