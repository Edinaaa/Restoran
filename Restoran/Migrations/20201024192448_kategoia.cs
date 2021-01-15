using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class kategoia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Artikli",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_KategorijaId",
                table: "Artikli",
                column: "KategorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Kategorija_KategorijaId",
                table: "Artikli",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "KategorijaId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Kategorija_KategorijaId",
                table: "Artikli");

            migrationBuilder.DropIndex(
                name: "IX_Artikli_KategorijaId",
                table: "Artikli");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Artikli");
        }
    }
}
