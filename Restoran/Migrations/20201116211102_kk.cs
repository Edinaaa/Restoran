using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class kk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkeMenias_Kategorijas_KategorijaId",
                table: "StavkeMenias");

            migrationBuilder.AlterColumn<int>(
                name: "KategorijaId",
                table: "StavkeMenias",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_StavkeMenias_Kategorijas_KategorijaId",
                table: "StavkeMenias");

            migrationBuilder.AlterColumn<int>(
                name: "KategorijaId",
                table: "StavkeMenias",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
