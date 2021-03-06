﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restoran.Database;

namespace Restoran.Migrations
{
    [DbContext(typeof(eRestoranContext))]
    [Migration("20210201113654_unique")]
    partial class unique
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restoran.Database.Artikal", b =>
                {
                    b.Property<int>("ArtikalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<double>("CijenaSaPdv")
                        .HasColumnType("float");

                    b.Property<int>("JedinicaMjereId")
                        .HasColumnType("int");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<float>("Kolicina")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("PDV")
                        .HasColumnType("int");

                    b.Property<int>("Popust")
                        .HasColumnType("int");

                    b.Property<string>("Sastav")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<byte[]>("Slika")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ArtikalId");

                    b.HasIndex("JedinicaMjereId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Artikli");
                });

            modelBuilder.Entity("Restoran.Database.JedinicaMjere", b =>
                {
                    b.Property<int>("JedinicaMjereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("JedinicaMjereId");

                    b.HasIndex("Naziv")
                        .IsUnique();

                    b.ToTable("JedinicaMjeres");
                });

            modelBuilder.Entity("Restoran.Database.Kategorija", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("KategorijaId");

                    b.HasIndex("Naziv")
                        .IsUnique();

                    b.ToTable("Kategorijas");
                });

            modelBuilder.Entity("Restoran.Database.Kombinacija", b =>
                {
                    b.Property<int>("KombinacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<double>("CijenaSaPdv")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("PDV")
                        .HasColumnType("int");

                    b.Property<int>("PonudaId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Slika")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("KombinacijaId");

                    b.HasIndex("PonudaId");

                    b.ToTable("Kombinacijas");
                });

            modelBuilder.Entity("Restoran.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodenja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumZaposljavanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<double>("IznosKredita")
                        .HasColumnType("float");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LozinkaHesh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<byte[]>("Slika")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.HasKey("KorisnikId");

                    b.HasIndex("KorisnickoIme")
                        .IsUnique()
                        .HasFilter("[KorisnickoIme] IS NOT NULL");

                    b.ToTable("Korisniks");
                });

            modelBuilder.Entity("Restoran.Database.KorisnikUloga", b =>
                {
                    b.Property<int>("KorisnikUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("UlogeId")
                        .HasColumnType("int");

                    b.HasKey("KorisnikUlogaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogeId");

                    b.ToTable("KorisnikUlogas");
                });

            modelBuilder.Entity("Restoran.Database.Meni", b =>
                {
                    b.Property<int>("MeniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vazeci")
                        .HasColumnType("bit");

                    b.HasKey("MeniId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Menis");
                });

            modelBuilder.Entity("Restoran.Database.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojStola")
                        .HasColumnType("int");

                    b.Property<double?>("Cijena")
                        .HasColumnType("float");

                    b.Property<double?>("CijenaSaPdv")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<bool>("Naplaceno")
                        .HasColumnType("bit");

                    b.Property<bool>("Naplati")
                        .HasColumnType("bit");

                    b.Property<bool>("Odbijena")
                        .HasColumnType("bit");

                    b.Property<bool>("Odobrena")
                        .HasColumnType("bit");

                    b.Property<float?>("Pdv")
                        .HasColumnType("real");

                    b.Property<bool>("PlacanjeKreditima")
                        .HasColumnType("bit");

                    b.HasKey("NarudzbaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Narudzbas");
                });

            modelBuilder.Entity("Restoran.Database.Ponuda", b =>
                {
                    b.Property<int>("PonudaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumZavrsetka")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.HasKey("PonudaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Ponudas");
                });

            modelBuilder.Entity("Restoran.Database.StavkaNarudzbe", b =>
                {
                    b.Property<int>("StavkaNarudzbeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<double>("CijenaSaPdv")
                        .HasColumnType("float");

                    b.Property<float>("Kolicina")
                        .HasColumnType("real");

                    b.Property<int?>("KombinacijaId")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaId")
                        .HasColumnType("int");

                    b.Property<int>("Pdv")
                        .HasColumnType("int");

                    b.Property<int?>("StavkeMenijaId")
                        .HasColumnType("int");

                    b.HasKey("StavkaNarudzbeId");

                    b.HasIndex("KombinacijaId");

                    b.HasIndex("NarudzbaId");

                    b.HasIndex("StavkeMenijaId");

                    b.ToTable("StavkaNarudzbes");
                });

            modelBuilder.Entity("Restoran.Database.StavkeKombinacije", b =>
                {
                    b.Property<int>("StavkeKombinacijeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtikalId")
                        .HasColumnType("int");

                    b.Property<float>("Kolicina")
                        .HasColumnType("real");

                    b.Property<int>("KombinacijaId")
                        .HasColumnType("int");

                    b.HasKey("StavkeKombinacijeId");

                    b.HasIndex("ArtikalId");

                    b.HasIndex("KombinacijaId");

                    b.ToTable("StavkeKombinacijes");
                });

            modelBuilder.Entity("Restoran.Database.StavkeMenija", b =>
                {
                    b.Property<int>("StavkeMenijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<int>("ArtikalId")
                        .HasColumnType("int");

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<double>("CijenaSaPDV")
                        .HasColumnType("float");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<int>("MeniId")
                        .HasColumnType("int");

                    b.Property<int>("PDV")
                        .HasColumnType("int");

                    b.Property<int>("Popust")
                        .HasColumnType("int");

                    b.HasKey("StavkeMenijaId");

                    b.HasIndex("ArtikalId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("MeniId");

                    b.ToTable("StavkeMenias");
                });

            modelBuilder.Entity("Restoran.Database.StavkeZahtjeva", b =>
                {
                    b.Property<int>("StavkeZahtjevaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("ZahtjevId")
                        .HasColumnType("int");

                    b.Property<bool>("ZahtjevObradjen")
                        .HasColumnType("bit");

                    b.HasKey("StavkeZahtjevaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ZahtjevId");

                    b.ToTable("StavkeZahtjevas");
                });

            modelBuilder.Entity("Restoran.Database.Uloge", b =>
                {
                    b.Property<int>("UlogeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("UlogeId");

                    b.HasIndex("Naziv")
                        .IsUnique();

                    b.ToTable("Uloges");
                });

            modelBuilder.Entity("Restoran.Database.Zahtjev", b =>
                {
                    b.Property<int>("ZahtjevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ZahtjevId");

                    b.HasIndex("Naziv")
                        .IsUnique();

                    b.ToTable("Zahtjevs");
                });

            modelBuilder.Entity("Restoran.Database.Artikal", b =>
                {
                    b.HasOne("Restoran.Database.JedinicaMjere", "JedinicaMjere")
                        .WithMany()
                        .HasForeignKey("JedinicaMjereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.Kombinacija", b =>
                {
                    b.HasOne("Restoran.Database.Ponuda", "Ponuda")
                        .WithMany()
                        .HasForeignKey("PonudaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.KorisnikUloga", b =>
                {
                    b.HasOne("Restoran.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.Uloge", "Uloge")
                        .WithMany()
                        .HasForeignKey("UlogeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.Meni", b =>
                {
                    b.HasOne("Restoran.Database.Korisnik", "Konobar")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.Narudzba", b =>
                {
                    b.HasOne("Restoran.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.Ponuda", b =>
                {
                    b.HasOne("Restoran.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.StavkaNarudzbe", b =>
                {
                    b.HasOne("Restoran.Database.Kombinacija", "Kombinacija")
                        .WithMany()
                        .HasForeignKey("KombinacijaId");

                    b.HasOne("Restoran.Database.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("NarudzbaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.StavkeMenija", "StavkeMenia")
                        .WithMany()
                        .HasForeignKey("StavkeMenijaId");
                });

            modelBuilder.Entity("Restoran.Database.StavkeKombinacije", b =>
                {
                    b.HasOne("Restoran.Database.Artikal", "Artikal")
                        .WithMany()
                        .HasForeignKey("ArtikalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.Kombinacija", "Kombinacija")
                        .WithMany()
                        .HasForeignKey("KombinacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.StavkeMenija", b =>
                {
                    b.HasOne("Restoran.Database.Artikal", "Artikal")
                        .WithMany()
                        .HasForeignKey("ArtikalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.Meni", "Meni")
                        .WithMany()
                        .HasForeignKey("MeniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.StavkeZahtjeva", b =>
                {
                    b.HasOne("Restoran.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.Zahtjev", "Zahtjev")
                        .WithMany()
                        .HasForeignKey("ZahtjevId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
