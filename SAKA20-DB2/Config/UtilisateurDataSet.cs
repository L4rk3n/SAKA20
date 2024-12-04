using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAKA20_DB.Entities;


namespace SAKA20_DB.Config
{
    public class UtilisateurDataSet : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.HasData(
                
                new Utilisateur
                {
                    IDutilisateur = 1,
                    Nom = "Dupont",
                    Prenom = "Jean",
                    Email = "jean.dupont@example.com",
                    Password = "password123",
                    PhoneNumber = 0498123456,
                    Admin = false,
                    Activated = false,
                    Cancelled = false,
                    AdresseRue = "Rue de la Paix",
                    AdresseNumero = 10,
                    AdresseCodePostal = 1000,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 1,
                    AdresseCountry = "Belgique"
                },
                new Utilisateur
                {
                    IDutilisateur = 2,
                    Nom = "Martin",
                    Prenom = "Sophie",
                    Email = "sophie.martin@example.com",
                    Password = "password123",
                    PhoneNumber = 0498765432,
                    Admin = true,
                    Activated = true,
                    Cancelled = false,
                    AdresseRue = "Avenue Louise",
                    AdresseNumero = 20,
                    AdresseCodePostal = 1050,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 2,
                    AdresseCountry = "Belgique"
                },
                new Utilisateur
                {
                    IDutilisateur = 3,
                    Nom = "Bernard",
                    Prenom = "Marie",
                    Email = "marie.bernard@example.com",
                    Password = "password123",
                    PhoneNumber = 0498543210,
                    Admin = false,
                    Activated = true,
                    Cancelled = false,
                    AdresseRue = "Chaussée de Mons",
                    AdresseNumero = 30,
                    AdresseCodePostal = 1070,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 3,
                    AdresseCountry = "Belgique"
                },
                new Utilisateur
                {
                    IDutilisateur = 4,
                    Nom = "Leroy",
                    Prenom = "Paul",
                    Email = "paul.leroy@example.com",
                    Password = "password123",
                    PhoneNumber = 0498432109,
                    Admin = false,
                    Activated = false,
                    Cancelled = false,
                    AdresseRue = "Rue Royale",
                    AdresseNumero = 40,
                    AdresseCodePostal = 1000,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 4,
                    AdresseCountry = "Belgique"
                },
                new Utilisateur
                {
                    IDutilisateur = 5,
                    Nom = "Dupuis",
                    Prenom = "Julie",
                    Email = "julie.dupuis@example.com",
                    Password = "password123",
                    PhoneNumber = 0498321098,
                    Admin = false,
                    Activated = true,
                    Cancelled = false,
                    AdresseRue = "Boulevard Anspach",
                    AdresseNumero = 50,
                    AdresseCodePostal = 1000,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 5,
                    AdresseCountry = "Belgique"
                },
                new Utilisateur
                {
                    IDutilisateur = 6,
                    Nom = "Moreau",
                    Prenom = "Pierre",
                    Email = "pierre.moreau@example.com",
                    Password = "password123",
                    PhoneNumber = 0498210987,
                    Admin = true,
                    Activated = true,
                    Cancelled = false,
                    AdresseRue = "Place du Luxembourg",
                    AdresseNumero = 60,
                    AdresseCodePostal = 1050,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 6,
                    AdresseCountry = "Belgique"
                },
                new Utilisateur
                {
                    IDutilisateur = 7,
                    Nom = "Renard",
                    Prenom = "Claire",
                    Email = "claire.renard@example.com",
                    Password = "password123",
                    PhoneNumber = 0498109876,
                    Admin = false,
                    Activated = false,
                    Cancelled = false,
                    AdresseRue = "Rue de la Loi",
                    AdresseNumero = 70,
                    AdresseCodePostal = 1040,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 7,
                    AdresseCountry = "Belgique"
                },
                new Utilisateur
                {
                    IDutilisateur = 8,
                    Nom = "Lemoine",
                    Prenom = "Luc",
                    Email = "luc.lemoine@example.com",
                    Password = "password123",
                    PhoneNumber = 0498098765,
                    Admin = false,
                    Activated = true,
                    Cancelled = false,
                    AdresseRue = "Rue des Bouchers",
                    AdresseNumero = 80,
                    AdresseCodePostal = 1000,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 8,
                    AdresseCountry = "Belgique"
                },
                new Utilisateur
                {
                    IDutilisateur = 9,
                    Nom = "Petit",
                    Prenom = "Nathalie",
                    Email = "nathalie.petit@example.com",
                    Password = "password123",
                    PhoneNumber = 0497987654,
                    Admin = false,
                    Activated = false,
                    Cancelled = false,
                    AdresseRue = "Avenue des Arts",
                    AdresseNumero = 90,
                    AdresseCodePostal = 1000,
                    AdresseVille = "Bruxelles",
                    AdresseNumeroBoite = 9,
                    AdresseCountry = "Belgique"
                }
               
            );
        }

    }
}
