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
    [Migration("20201023162903_jm")]
    partial class jm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
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

                    b.Property<float>("Kolicina")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PDV")
                        .HasColumnType("real");

                    b.Property<double>("Popust")
                        .HasColumnType("float");

                    b.Property<string>("Sastav")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ArtikalId");

                    b.HasIndex("JedinicaMjereId");

                    b.ToTable("Artikli");
                });

            modelBuilder.Entity("Restoran.Database.JedinicaMjere", b =>
                {
                    b.Property<int>("JedinicaMjereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JedinicaMjereId");

                    b.ToTable("JedinicaMjeres");
                });

            modelBuilder.Entity("Restoran.Database.Kategorija", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorija");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PonudaId")
                        .HasColumnType("int");

                    b.HasKey("KombinacijaId");

                    b.HasIndex("PonudaId");

                    b.ToTable("Kombinacija");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("IznosKredita")
                        .HasColumnType("float");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHesh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikId");

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

                    b.Property<int>("ArtikaId")
                        .HasColumnType("int");

                    b.Property<int?>("ArtikalId")
                        .HasColumnType("int");

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<double>("CijenaSaPdv")
                        .HasColumnType("float");

                    b.Property<float>("Kolicina")
                        .HasColumnType("real");

                    b.Property<int>("NarudzbaId")
                        .HasColumnType("int");

                    b.Property<float>("Pdv")
                        .HasColumnType("real");

                    b.HasKey("StavkaNarudzbeId");

                    b.HasIndex("ArtikalId");

                    b.HasIndex("NarudzbaId");

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

                    b.Property<int>("JedinicaMjereId")
                        .HasColumnType("int");

                    b.Property<float>("Kolicina")
                        .HasColumnType("real");

                    b.Property<int>("KombinacijaId")
                        .HasColumnType("int");

                    b.HasKey("StavkeKombinacijeId");

                    b.HasIndex("ArtikalId");

                    b.HasIndex("JedinicaMjereId");

                    b.HasIndex("KombinacijaId");

                    b.ToTable("StavkeKombinacijes");
                });

            modelBuilder.Entity("Restoran.Database.StavkeMenia", b =>
                {
                    b.Property<int>("StavkeMeniaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<float>("Popust")
                        .HasColumnType("real");

                    b.HasKey("StavkeMeniaId");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogeId");

                    b.ToTable("Uloges");
                });

            modelBuilder.Entity("Restoran.Database.Zahtjev", b =>
                {
                    b.Property<int>("ZahtjevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZahtjevId");

                    b.ToTable("Zahtjevs");
                });

            modelBuilder.Entity("Restoran.Database.Artikal", b =>
                {
                    b.HasOne("Restoran.Database.JedinicaMjere", "JedinicaMjere")
                        .WithMany()
                        .HasForeignKey("JedinicaMjereId")
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
                    b.HasOne("Restoran.Database.Artikal", "Artikal")
                        .WithMany()
                        .HasForeignKey("ArtikalId");

                    b.HasOne("Restoran.Database.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("NarudzbaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.StavkeKombinacije", b =>
                {
                    b.HasOne("Restoran.Database.Artikal", "Artikal")
                        .WithMany()
                        .HasForeignKey("ArtikalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.JedinicaMjere", "JedinicaMjere")
                        .WithMany()
                        .HasForeignKey("JedinicaMjereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restoran.Database.Kombinacija", "Kombinacija")
                        .WithMany()
                        .HasForeignKey("KombinacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restoran.Database.StavkeMenia", b =>
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
