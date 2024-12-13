﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SAKA20_DB;

#nullable disable

namespace SAKA20_DB2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SAKA20_DB.Entities.Utilisateur", b =>
                {
                    b.Property<int>("IDutilisateur")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDutilisateur"));

                    b.Property<bool>("Activated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("Admin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("AdresseCodePostal")
                        .HasColumnType("int");

                    b.Property<string>("AdresseCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdresseNumero")
                        .HasColumnType("int");

                    b.Property<int>("AdresseNumeroBoite")
                        .HasColumnType("int");

                    b.Property<string>("AdresseRue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresseVille")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cancelled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDutilisateur");

                    b.ToTable("Utilisateur");

                    b.HasData(
                        new
                        {
                            IDutilisateur = 1,
                            Activated = false,
                            Admin = false,
                            AdresseCodePostal = 1000,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 10,
                            AdresseNumeroBoite = 1,
                            AdresseRue = "Rue de la Paix",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "jean.dupont@example.com",
                            Nom = "Dupont",
                            Password = "password123",
                            PhoneNumber = 498123456,
                            Prenom = "Jean"
                        },
                        new
                        {
                            IDutilisateur = 2,
                            Activated = true,
                            Admin = true,
                            AdresseCodePostal = 1050,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 20,
                            AdresseNumeroBoite = 2,
                            AdresseRue = "Avenue Louise",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "sophie.martin@example.com",
                            Nom = "Martin",
                            Password = "password123",
                            PhoneNumber = 498765432,
                            Prenom = "Sophie"
                        },
                        new
                        {
                            IDutilisateur = 3,
                            Activated = true,
                            Admin = false,
                            AdresseCodePostal = 1070,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 30,
                            AdresseNumeroBoite = 3,
                            AdresseRue = "Chaussée de Mons",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "marie.bernard@example.com",
                            Nom = "Bernard",
                            Password = "password123",
                            PhoneNumber = 498543210,
                            Prenom = "Marie"
                        },
                        new
                        {
                            IDutilisateur = 4,
                            Activated = false,
                            Admin = false,
                            AdresseCodePostal = 1000,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 40,
                            AdresseNumeroBoite = 4,
                            AdresseRue = "Rue Royale",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "paul.leroy@example.com",
                            Nom = "Leroy",
                            Password = "password123",
                            PhoneNumber = 498432109,
                            Prenom = "Paul"
                        },
                        new
                        {
                            IDutilisateur = 5,
                            Activated = true,
                            Admin = false,
                            AdresseCodePostal = 1000,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 50,
                            AdresseNumeroBoite = 5,
                            AdresseRue = "Boulevard Anspach",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "julie.dupuis@example.com",
                            Nom = "Dupuis",
                            Password = "password123",
                            PhoneNumber = 498321098,
                            Prenom = "Julie"
                        },
                        new
                        {
                            IDutilisateur = 6,
                            Activated = true,
                            Admin = true,
                            AdresseCodePostal = 1050,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 60,
                            AdresseNumeroBoite = 6,
                            AdresseRue = "Place du Luxembourg",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "pierre.moreau@example.com",
                            Nom = "Moreau",
                            Password = "password123",
                            PhoneNumber = 498210987,
                            Prenom = "Pierre"
                        },
                        new
                        {
                            IDutilisateur = 7,
                            Activated = false,
                            Admin = false,
                            AdresseCodePostal = 1040,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 70,
                            AdresseNumeroBoite = 7,
                            AdresseRue = "Rue de la Loi",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "claire.renard@example.com",
                            Nom = "Renard",
                            Password = "password123",
                            PhoneNumber = 498109876,
                            Prenom = "Claire"
                        },
                        new
                        {
                            IDutilisateur = 8,
                            Activated = true,
                            Admin = false,
                            AdresseCodePostal = 1000,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 80,
                            AdresseNumeroBoite = 8,
                            AdresseRue = "Rue des Bouchers",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "luc.lemoine@example.com",
                            Nom = "Lemoine",
                            Password = "password123",
                            PhoneNumber = 498098765,
                            Prenom = "Luc"
                        },
                        new
                        {
                            IDutilisateur = 9,
                            Activated = false,
                            Admin = false,
                            AdresseCodePostal = 1000,
                            AdresseCountry = "Belgique",
                            AdresseNumero = 90,
                            AdresseNumeroBoite = 9,
                            AdresseRue = "Avenue des Arts",
                            AdresseVille = "Bruxelles",
                            Cancelled = false,
                            Email = "nathalie.petit@example.com",
                            Nom = "Petit",
                            Password = "password123",
                            PhoneNumber = 497987654,
                            Prenom = "Nathalie"
                        });
                });

            modelBuilder.Entity("SAKA20_DB2.Entities.Vin", b =>
                {
                    b.Property<int>("Idvin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idvin"));

                    b.Property<int>("Cuvee")
                        .HasColumnType("int");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<string>("Empalpha")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("Empnum")
                        .HasColumnType("int");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Fournisseur")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Prix")
                        .HasColumnType("int");

                    b.Property<int>("Prixtva")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Idvin");

                    b.ToTable("Vin");

                    b.HasData(
                        new
                        {
                            Idvin = 1,
                            Cuvee = 2015,
                            Disponible = true,
                            Empalpha = "AA",
                            Empnum = 1,
                            Format = "75cl",
                            Fournisseur = "Vins & Co",
                            Nom = "Château Margaux",
                            Prix = 250,
                            Prixtva = 300,
                            Stock = 50,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 2,
                            Cuvee = 2016,
                            Disponible = true,
                            Empalpha = "AB",
                            Empnum = 2,
                            Format = "75cl",
                            Fournisseur = "Vins & Co",
                            Nom = "Domaine de la Romanée-Conti",
                            Prix = 500,
                            Prixtva = 600,
                            Stock = 20,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 3,
                            Cuvee = 2014,
                            Disponible = false,
                            Empalpha = "AC",
                            Empnum = 3,
                            Format = "75cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "Pétrus",
                            Prix = 700,
                            Prixtva = 850,
                            Stock = 0,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 4,
                            Cuvee = 2017,
                            Disponible = true,
                            Empalpha = "AD",
                            Empnum = 4,
                            Format = "75cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "Château Lafite Rothschild",
                            Prix = 450,
                            Prixtva = 540,
                            Stock = 30,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 5,
                            Cuvee = 2018,
                            Disponible = true,
                            Empalpha = "AE",
                            Empnum = 5,
                            Format = "75cl",
                            Fournisseur = "Cave de Luxe",
                            Nom = "Opus One",
                            Prix = 400,
                            Prixtva = 480,
                            Stock = 15,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 6,
                            Cuvee = 2015,
                            Disponible = true,
                            Empalpha = "AF",
                            Empnum = 6,
                            Format = "75cl",
                            Fournisseur = "Cave de Luxe",
                            Nom = "Sassicaia",
                            Prix = 300,
                            Prixtva = 360,
                            Stock = 25,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 7,
                            Cuvee = 2013,
                            Disponible = false,
                            Empalpha = "AG",
                            Empnum = 7,
                            Format = "75cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "Château d'Yquem",
                            Prix = 600,
                            Prixtva = 720,
                            Stock = 0,
                            Type = "Blanc"
                        },
                        new
                        {
                            Idvin = 8,
                            Cuvee = 2016,
                            Disponible = true,
                            Empalpha = "AH",
                            Empnum = 8,
                            Format = "75cl",
                            Fournisseur = "Cave de Luxe",
                            Nom = "Penfolds Grange",
                            Prix = 350,
                            Prixtva = 420,
                            Stock = 35,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 9,
                            Cuvee = 2014,
                            Disponible = true,
                            Empalpha = "AI",
                            Empnum = 9,
                            Format = "75cl",
                            Fournisseur = "Vins & Co",
                            Nom = "Vega Sicilia",
                            Prix = 480,
                            Prixtva = 570,
                            Stock = 40,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 10,
                            Cuvee = 2017,
                            Disponible = true,
                            Empalpha = "AJ",
                            Empnum = 10,
                            Format = "75cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "Château Latour",
                            Prix = 550,
                            Prixtva = 660,
                            Stock = 45,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 11,
                            Cuvee = 2015,
                            Disponible = false,
                            Empalpha = "AK",
                            Empnum = 1,
                            Format = "75cl",
                            Fournisseur = "Vins & Co",
                            Nom = "Domaine Leflaive",
                            Prix = 650,
                            Prixtva = 780,
                            Stock = 0,
                            Type = "Blanc"
                        },
                        new
                        {
                            Idvin = 12,
                            Cuvee = 2016,
                            Disponible = true,
                            Empalpha = "AL",
                            Empnum = 2,
                            Format = "75cl",
                            Fournisseur = "Cave de Luxe",
                            Nom = "Château Haut-Brion",
                            Prix = 430,
                            Prixtva = 516,
                            Stock = 28,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 13,
                            Cuvee = 2018,
                            Disponible = true,
                            Empalpha = "AM",
                            Empnum = 3,
                            Format = "75cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "Almaviva",
                            Prix = 270,
                            Prixtva = 324,
                            Stock = 32,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 14,
                            Cuvee = 2017,
                            Disponible = true,
                            Empalpha = "AN",
                            Empnum = 4,
                            Format = "75cl",
                            Fournisseur = "Vins & Co",
                            Nom = "Guigal La Landonne",
                            Prix = 380,
                            Prixtva = 456,
                            Stock = 22,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 15,
                            Cuvee = 2016,
                            Disponible = false,
                            Empalpha = "AO",
                            Empnum = 5,
                            Format = "75cl",
                            Fournisseur = "Cave de Luxe",
                            Nom = "Masseto",
                            Prix = 710,
                            Prixtva = 852,
                            Stock = 0,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 16,
                            Cuvee = 2014,
                            Disponible = true,
                            Empalpha = "AP",
                            Empnum = 6,
                            Format = "75cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "Château Palmer",
                            Prix = 340,
                            Prixtva = 408,
                            Stock = 37,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 17,
                            Cuvee = 2018,
                            Disponible = true,
                            Empalpha = "AQ",
                            Empnum = 7,
                            Format = "75cl",
                            Fournisseur = "Vins & Co",
                            Nom = "Château Mouton Rothschild",
                            Prix = 460,
                            Prixtva = 552,
                            Stock = 33,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 18,
                            Cuvee = 2015,
                            Disponible = true,
                            Empalpha = "AR",
                            Empnum = 8,
                            Format = "75cl",
                            Fournisseur = "Cave de Luxe",
                            Nom = "Tignanello",
                            Prix = 320,
                            Prixtva = 384,
                            Stock = 30,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 19,
                            Cuvee = 2017,
                            Disponible = true,
                            Empalpha = "AS",
                            Empnum = 9,
                            Format = "75cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "La Tâche",
                            Prix = 540,
                            Prixtva = 648,
                            Stock = 27,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 20,
                            Cuvee = 2016,
                            Disponible = false,
                            Empalpha = "AT",
                            Empnum = 10,
                            Format = "75cl",
                            Fournisseur = "Vins & Co",
                            Nom = "Screaming Eagle",
                            Prix = 800,
                            Prixtva = 960,
                            Stock = 5,
                            Type = "Rouge"
                        },
                        new
                        {
                            Idvin = 21,
                            Cuvee = 2018,
                            Disponible = true,
                            Empalpha = "AU",
                            Empnum = 1,
                            Format = "75cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "Chablis Grand Cru",
                            Prix = 220,
                            Prixtva = 264,
                            Stock = 50,
                            Type = "Blanc"
                        },
                        new
                        {
                            Idvin = 22,
                            Cuvee = 2019,
                            Disponible = true,
                            Empalpha = "AV",
                            Empnum = 2,
                            Format = "75cl",
                            Fournisseur = "Cave de Luxe",
                            Nom = "Puligny-Montrachet",
                            Prix = 300,
                            Prixtva = 360,
                            Stock = 25,
                            Type = "Blanc"
                        },
                        new
                        {
                            Idvin = 23,
                            Cuvee = 2017,
                            Disponible = true,
                            Empalpha = "AW",
                            Empnum = 3,
                            Format = "75cl",
                            Fournisseur = "Vins & Co",
                            Nom = "Riesling Grand Cru",
                            Prix = 180,
                            Prixtva = 216,
                            Stock = 40,
                            Type = "Blanc"
                        },
                        new
                        {
                            Idvin = 24,
                            Cuvee = 2016,
                            Disponible = true,
                            Empalpha = "AX",
                            Empnum = 4,
                            Format = "62cl",
                            Fournisseur = "Les Domaines Français",
                            Nom = "Vin Jaune d'Arbois",
                            Prix = 450,
                            Prixtva = 540,
                            Stock = 20,
                            Type = "Jaune"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
