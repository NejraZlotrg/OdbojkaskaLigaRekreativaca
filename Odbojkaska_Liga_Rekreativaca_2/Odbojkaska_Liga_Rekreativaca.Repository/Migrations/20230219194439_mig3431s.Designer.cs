﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Odbojkaska_Liga_Rekreativaca.Repository;

#nullable disable

namespace OdbojkaskaLigaRekreativaca.Repository.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230219194439_mig3431s")]
    partial class mig3431s
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("twoFCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("twoFJelOtkljucano")
                        .HasColumnType("bit");

                    b.Property<string>("vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnikID");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Dvorana", b =>
                {
                    b.Property<int>("DvoranaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DvoranaID"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("ImeDvorane")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("DvoranaID");

                    b.HasIndex("GradID");

                    b.ToTable("dvorana");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradID"));

                    b.Property<string>("ImeGrada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KantonID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("GradID");

                    b.HasIndex("KantonID");

                    b.ToTable("grad");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Igrac", b =>
                {
                    b.Property<int>("IgraciD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IgraciD"));

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAdresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PozicijaID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpolID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("IgraciD");

                    b.HasIndex("GradID");

                    b.HasIndex("PozicijaID");

                    b.HasIndex("SpolID");

                    b.ToTable("igrac");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Kanton", b =>
                {
                    b.Property<int>("KantonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KantonID"));

                    b.Property<string>("NazivKantona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("KantonID");

                    b.ToTable("kanton");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Kolo", b =>
                {
                    b.Property<int>("KoloID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KoloID"));

                    b.Property<int>("BrojKola")
                        .HasColumnType("int");

                    b.Property<int>("LigaID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("KoloID");

                    b.HasIndex("LigaID");

                    b.ToTable("kolo");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikID"));

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpolID")
                        .HasColumnType("int");

                    b.Property<string>("aktivacijaGUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isAktiviran")
                        .HasColumnType("bit");

                    b.Property<bool>("isSudija")
                        .HasColumnType("bit");

                    b.Property<bool>("isZapisnicar")
                        .HasColumnType("bit");

                    b.Property<string>("korisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("KorisnikID");

                    b.HasIndex("GradID");

                    b.HasIndex("SpolID");

                    b.ToTable("korisnik");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.KorisnikUloga", b =>
                {
                    b.Property<int>("KorisnikUlogaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikUlogaID"));

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("UlogaID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("KorisnikUlogaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("UlogaID");

                    b.ToTable("korisnikUloga");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Liga", b =>
                {
                    b.Property<int>("LigaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LigaID"));

                    b.Property<string>("GodinaLige")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("LigaID");

                    b.ToTable("liga");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.LigaDvorana", b =>
                {
                    b.Property<int>("LigaDvoranaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LigaDvoranaID"));

                    b.Property<int>("DvoranaID")
                        .HasColumnType("int");

                    b.Property<int>("LigaID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("LigaDvoranaID");

                    b.HasIndex("DvoranaID");

                    b.HasIndex("LigaID");

                    b.ToTable("ligaDvorana");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Pozicija", b =>
                {
                    b.Property<int>("PozicijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PozicijaID"));

                    b.Property<string>("NazivPozicije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("PozicijaID");

                    b.ToTable("pozicija");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Rezultati", b =>
                {
                    b.Property<int>("RezultatiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezultatiID"));

                    b.Property<int>("IzgubljeniBodovi")
                        .HasColumnType("int");

                    b.Property<int>("OsvojeniBodovi")
                        .HasColumnType("int");

                    b.Property<int>("SetoviID")
                        .HasColumnType("int");

                    b.Property<int>("TimID")
                        .HasColumnType("int");

                    b.Property<int>("UtakmicaID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("RezultatiID");

                    b.HasIndex("SetoviID");

                    b.HasIndex("TimID");

                    b.HasIndex("UtakmicaID");

                    b.ToTable("rezultati");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Setovi", b =>
                {
                    b.Property<int>("SetoviID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SetoviID"));

                    b.Property<string>("BrojSeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("SetoviID");

                    b.ToTable("setovi");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Spol", b =>
                {
                    b.Property<int>("SpolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpolID"));

                    b.Property<string>("NazivSpola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("SpolID");

                    b.ToTable("spol");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"));

                    b.Property<string>("NazivStatusa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("StatusID");

                    b.ToTable("status");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Tim", b =>
                {
                    b.Property<int>("TimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimID"));

                    b.Property<string>("ImeTima")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("TimID");

                    b.ToTable("tim");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.TimIgrac", b =>
                {
                    b.Property<int>("TimIgracID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimIgracID"));

                    b.Property<int>("IgracID")
                        .HasColumnType("int");

                    b.Property<int>("TimID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("TimIgracID");

                    b.HasIndex("IgracID");

                    b.HasIndex("TimID");

                    b.ToTable("timIgrac");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.TimLiga", b =>
                {
                    b.Property<int>("TimLigaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimLigaID"));

                    b.Property<DateTime>("DatumPrijave")
                        .HasColumnType("datetime2");

                    b.Property<int>("LigaID")
                        .HasColumnType("int");

                    b.Property<int>("TimIgracID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("TimLigaID");

                    b.HasIndex("LigaID");

                    b.HasIndex("TimIgracID");

                    b.ToTable("timLiga");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Uloga", b =>
                {
                    b.Property<int>("UlogaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlogaID"));

                    b.Property<string>("NazivUloge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("UlogaID");

                    b.ToTable("uloga");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Utakmica", b =>
                {
                    b.Property<int>("UtakmicaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UtakmicaID"));

                    b.Property<DateTime>("DatumIgranja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KoloID")
                        .HasColumnType("int");

                    b.Property<string>("NazivUtakmice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<DateTime>("VrijemePocetka")
                        .HasColumnType("datetime2");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("UtakmicaID");

                    b.HasIndex("KoloID");

                    b.HasIndex("StatusID");

                    b.ToTable("utakmica");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.UtakmicaKorisnik", b =>
                {
                    b.Property<int>("UtakmicaKorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UtakmicaKorisnikID"));

                    b.Property<int>("KorisnikUlogaID")
                        .HasColumnType("int");

                    b.Property<int>("UtakmicaID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("UtakmicaKorisnikID");

                    b.HasIndex("KorisnikUlogaID");

                    b.HasIndex("UtakmicaID");

                    b.ToTable("utakmicaKorisnik");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.UtakmicaTimLiga", b =>
                {
                    b.Property<int>("UtakmicaTimLigaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UtakmicaTimLigaID"));

                    b.Property<int>("TimLigaID")
                        .HasColumnType("int");

                    b.Property<int>("UtakmicaID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("UtakmicaTimLigaID");

                    b.HasIndex("TimLigaID");

                    b.HasIndex("UtakmicaID");

                    b.ToTable("UtakmicaTimLiga");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.UtakmicaTimLigaIgrac", b =>
                {
                    b.Property<int>("UtakmicaTimLigaIgracID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UtakmicaTimLigaIgracID"));

                    b.Property<int>("IgracID")
                        .HasColumnType("int");

                    b.Property<int>("UtakmicaTimLigaID")
                        .HasColumnType("int");

                    b.Property<bool>("obrisan")
                        .HasColumnType("bit");

                    b.HasKey("UtakmicaTimLigaIgracID");

                    b.HasIndex("IgracID");

                    b.HasIndex("UtakmicaTimLigaID");

                    b.ToTable("utakmicaTimLigaIgrac");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.AutentifikacijaToken", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Dvorana", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Grad", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Kanton", "Kanton")
                        .WithMany()
                        .HasForeignKey("KantonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kanton");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Igrac", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Pozicija", "Pozicija")
                        .WithMany()
                        .HasForeignKey("PozicijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Spol", "Spol")
                        .WithMany()
                        .HasForeignKey("SpolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("Pozicija");

                    b.Navigation("Spol");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Kolo", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Liga", "Liga")
                        .WithMany()
                        .HasForeignKey("LigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Liga");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Korisnik", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Spol", "Spol")
                        .WithMany()
                        .HasForeignKey("SpolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("Spol");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.KorisnikUloga", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Uloga", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.LigaDvorana", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Dvorana", "Dvorana")
                        .WithMany()
                        .HasForeignKey("DvoranaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Liga", "Liga")
                        .WithMany()
                        .HasForeignKey("LigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dvorana");

                    b.Navigation("Liga");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Rezultati", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Setovi", "Setovi")
                        .WithMany()
                        .HasForeignKey("SetoviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Tim", "Tim")
                        .WithMany()
                        .HasForeignKey("TimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Utakmica", "Utakmica")
                        .WithMany()
                        .HasForeignKey("UtakmicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Setovi");

                    b.Navigation("Tim");

                    b.Navigation("Utakmica");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.TimIgrac", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Igrac", "Igrac")
                        .WithMany()
                        .HasForeignKey("IgracID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Tim", "Tim")
                        .WithMany()
                        .HasForeignKey("TimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igrac");

                    b.Navigation("Tim");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.TimLiga", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Liga", "Liga")
                        .WithMany()
                        .HasForeignKey("LigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.TimIgrac", "TimIgrac")
                        .WithMany()
                        .HasForeignKey("TimIgracID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Liga");

                    b.Navigation("TimIgrac");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Utakmica", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Kolo", "Kolo")
                        .WithMany()
                        .HasForeignKey("KoloID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kolo");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.UtakmicaKorisnik", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.KorisnikUloga", "Korisnikuloga")
                        .WithMany()
                        .HasForeignKey("KorisnikUlogaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Utakmica", "Utakmica")
                        .WithMany()
                        .HasForeignKey("UtakmicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnikuloga");

                    b.Navigation("Utakmica");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.UtakmicaTimLiga", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.TimLiga", "TimLiga")
                        .WithMany()
                        .HasForeignKey("TimLigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Utakmica", "Utakmica")
                        .WithMany()
                        .HasForeignKey("UtakmicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TimLiga");

                    b.Navigation("Utakmica");
                });

            modelBuilder.Entity("Odbojkaska_Liga_Rekreativaca.Core.Modeli.UtakmicaTimLigaIgrac", b =>
                {
                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.Igrac", "Igrac")
                        .WithMany()
                        .HasForeignKey("IgracID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Odbojkaska_Liga_Rekreativaca.Core.Modeli.UtakmicaTimLiga", "UtakmicaTimLiga")
                        .WithMany()
                        .HasForeignKey("UtakmicaTimLigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igrac");

                    b.Navigation("UtakmicaTimLiga");
                });
#pragma warning restore 612, 618
        }
    }
}
