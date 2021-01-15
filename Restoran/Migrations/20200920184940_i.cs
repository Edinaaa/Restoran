using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restoran.Migrations
{
    public partial class i : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JedinicaMjeres",
                columns: table => new
                {
                    JedinicaMjereId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JedinicaMjeres", x => x.JedinicaMjereId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisniks",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    DatumRodenja = table.Column<DateTime>(nullable: false),
                    DatumZaposljavanja = table.Column<DateTime>(nullable: true),
                    IznosKredita = table.Column<double>(nullable: false),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true),
                    LozinkaHesh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisniks", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Uloges",
                columns: table => new
                {
                    UlogeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloges", x => x.UlogeId);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjevs",
                columns: table => new
                {
                    ZahtjevId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjevs", x => x.ZahtjevId);
                });

            migrationBuilder.CreateTable(
                name: "Artikli",
                columns: table => new
                {
                    ArtikalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    Popust = table.Column<double>(nullable: false),
                    PDV = table.Column<float>(nullable: false),
                    Sastav = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    CijenaSaPdv = table.Column<double>(nullable: false),
                    JedinicaMjereId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikli", x => x.ArtikalId);
                    table.ForeignKey(
                        name: "FK_Artikli_JedinicaMjeres_JedinicaMjereId",
                        column: x => x.JedinicaMjereId,
                        principalTable: "JedinicaMjeres",
                        principalColumn: "JedinicaMjereId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menis",
                columns: table => new
                {
                    MeniId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(nullable: false),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    Vazeci = table.Column<bool>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menis", x => x.MeniId);
                    table.ForeignKey(
                        name: "FK_Menis_Korisniks_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisniks",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Narudzbas",
                columns: table => new
                {
                    NarudzbaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumNarudzbe = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    PlacanjeKreditima = table.Column<bool>(nullable: false),
                    Naplaceno = table.Column<bool>(nullable: false),
                    Cijena = table.Column<double>(nullable: true),
                    CijenaSaPdv = table.Column<double>(nullable: true),
                    Pdv = table.Column<float>(nullable: true),
                    BrojStola = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbas", x => x.NarudzbaId);
                    table.ForeignKey(
                        name: "FK_Narudzbas_Korisniks_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisniks",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ponudas",
                columns: table => new
                {
                    PonudaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(nullable: false),
                    DatumPocetka = table.Column<DateTime>(nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponudas", x => x.PonudaId);
                    table.ForeignKey(
                        name: "FK_Ponudas_Korisniks_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisniks",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUlogas",
                columns: table => new
                {
                    KorisnikUlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(nullable: false),
                    UlogeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUlogas", x => x.KorisnikUlogaId);
                    table.ForeignKey(
                        name: "FK_KorisnikUlogas_Korisniks_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisniks",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikUlogas_Uloges_UlogeId",
                        column: x => x.UlogeId,
                        principalTable: "Uloges",
                        principalColumn: "UlogeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeZahtjevas",
                columns: table => new
                {
                    StavkeZahtjevaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZahtjevObradjen = table.Column<bool>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    ZahtjevId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeZahtjevas", x => x.StavkeZahtjevaId);
                    table.ForeignKey(
                        name: "FK_StavkeZahtjevas_Korisniks_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisniks",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeZahtjevas_Zahtjevs_ZahtjevId",
                        column: x => x.ZahtjevId,
                        principalTable: "Zahtjevs",
                        principalColumn: "ZahtjevId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeMenias",
                columns: table => new
                {
                    StavkeMeniaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeniId = table.Column<int>(nullable: false),
                    ArtikalId = table.Column<int>(nullable: false),
                    Popust = table.Column<float>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    CijenaSaPDV = table.Column<double>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeMenias", x => x.StavkeMeniaId);
                    table.ForeignKey(
                        name: "FK_StavkeMenias_Artikli_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeMenias_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeMenias_Menis_MeniId",
                        column: x => x.MeniId,
                        principalTable: "Menis",
                        principalColumn: "MeniId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkaNarudzbes",
                columns: table => new
                {
                    StavkaNarudzbeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtikaId = table.Column<int>(nullable: false),
                    ArtikalId = table.Column<int>(nullable: true),
                    NarudzbaId = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    Pdv = table.Column<float>(nullable: false),
                    Kolicina = table.Column<float>(nullable: false),
                    JedinicaMjereId = table.Column<int>(nullable: false),
                    CijenaSaPdv = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaNarudzbes", x => x.StavkaNarudzbeId);
                    table.ForeignKey(
                        name: "FK_StavkaNarudzbes_Artikli_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StavkaNarudzbes_JedinicaMjeres_JedinicaMjereId",
                        column: x => x.JedinicaMjereId,
                        principalTable: "JedinicaMjeres",
                        principalColumn: "JedinicaMjereId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkaNarudzbes_Narudzbas_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzbas",
                        principalColumn: "NarudzbaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kombinacija",
                columns: table => new
                {
                    KombinacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PonudaId = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    CijenaSaPdv = table.Column<double>(nullable: false),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kombinacija", x => x.KombinacijaId);
                    table.ForeignKey(
                        name: "FK_Kombinacija_Ponudas_PonudaId",
                        column: x => x.PonudaId,
                        principalTable: "Ponudas",
                        principalColumn: "PonudaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeKombinacijes",
                columns: table => new
                {
                    StavkeKombinacijeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KombinacijaId = table.Column<int>(nullable: false),
                    ArtikalId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<float>(nullable: false),
                    JedinicaMjereId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeKombinacijes", x => x.StavkeKombinacijeId);
                    table.ForeignKey(
                        name: "FK_StavkeKombinacijes_Artikli_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeKombinacijes_JedinicaMjeres_JedinicaMjereId",
                        column: x => x.JedinicaMjereId,
                        principalTable: "JedinicaMjeres",
                        principalColumn: "JedinicaMjereId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_StavkeKombinacijes_Kombinacija_KombinacijaId",
                        column: x => x.KombinacijaId,
                        principalTable: "Kombinacija",
                        principalColumn: "KombinacijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_JedinicaMjereId",
                table: "Artikli",
                column: "JedinicaMjereId");

            migrationBuilder.CreateIndex(
                name: "IX_Kombinacija_PonudaId",
                table: "Kombinacija",
                column: "PonudaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUlogas_KorisnikId",
                table: "KorisnikUlogas",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUlogas_UlogeId",
                table: "KorisnikUlogas",
                column: "UlogeId");

            migrationBuilder.CreateIndex(
                name: "IX_Menis_KorisnikId",
                table: "Menis",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzbas_KorisnikId",
                table: "Narudzbas",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Ponudas_KorisnikId",
                table: "Ponudas",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbes_ArtikalId",
                table: "StavkaNarudzbes",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbes_JedinicaMjereId",
                table: "StavkaNarudzbes",
                column: "JedinicaMjereId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaNarudzbes_NarudzbaId",
                table: "StavkaNarudzbes",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeKombinacijes_ArtikalId",
                table: "StavkeKombinacijes",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeKombinacijes_JedinicaMjereId",
                table: "StavkeKombinacijes",
                column: "JedinicaMjereId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeKombinacijes_KombinacijaId",
                table: "StavkeKombinacijes",
                column: "KombinacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeMenias_ArtikalId",
                table: "StavkeMenias",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeMenias_KategorijaId",
                table: "StavkeMenias",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeMenias_MeniId",
                table: "StavkeMenias",
                column: "MeniId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeZahtjevas_KorisnikId",
                table: "StavkeZahtjevas",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeZahtjevas_ZahtjevId",
                table: "StavkeZahtjevas",
                column: "ZahtjevId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisnikUlogas");

            migrationBuilder.DropTable(
                name: "StavkaNarudzbes");

            migrationBuilder.DropTable(
                name: "StavkeKombinacijes");

            migrationBuilder.DropTable(
                name: "StavkeMenias");

            migrationBuilder.DropTable(
                name: "StavkeZahtjevas");

            migrationBuilder.DropTable(
                name: "Uloges");

            migrationBuilder.DropTable(
                name: "Narudzbas");

            migrationBuilder.DropTable(
                name: "Kombinacija");

            migrationBuilder.DropTable(
                name: "Artikli");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Menis");

            migrationBuilder.DropTable(
                name: "Zahtjevs");

            migrationBuilder.DropTable(
                name: "Ponudas");

            migrationBuilder.DropTable(
                name: "JedinicaMjeres");

            migrationBuilder.DropTable(
                name: "Korisniks");
        }
    }
}
