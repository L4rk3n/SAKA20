using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAKA20_DB2.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 1, 1000, "Belgique", 10, 1, "Rue de la Paix", "Bruxelles", "jean.dupont@example.com", "Dupont", "password123", 498123456, "Jean" });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "Activated", "Admin", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 2, true, true, 1050, "Belgique", 20, 2, "Avenue Louise", "Bruxelles", "sophie.martin@example.com", "Martin", "password123", 498765432, "Sophie" });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "Activated", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 3, true, 1070, "Belgique", 30, 3, "Chaussée de Mons", "Bruxelles", "marie.bernard@example.com", "Bernard", "password123", 498543210, "Marie" });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 4, 1000, "Belgique", 40, 4, "Rue Royale", "Bruxelles", "paul.leroy@example.com", "Leroy", "password123", 498432109, "Paul" });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "Activated", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 5, true, 1000, "Belgique", 50, 5, "Boulevard Anspach", "Bruxelles", "julie.dupuis@example.com", "Dupuis", "password123", 498321098, "Julie" });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "Activated", "Admin", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 6, true, true, 1050, "Belgique", 60, 6, "Place du Luxembourg", "Bruxelles", "pierre.moreau@example.com", "Moreau", "password123", 498210987, "Pierre" });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 7, 1040, "Belgique", 70, 7, "Rue de la Loi", "Bruxelles", "claire.renard@example.com", "Renard", "password123", 498109876, "Claire" });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "Activated", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 8, true, 1000, "Belgique", 80, 8, "Rue des Bouchers", "Bruxelles", "luc.lemoine@example.com", "Lemoine", "password123", 498098765, "Luc" });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "IDutilisateur", "AdresseCodePostal", "AdresseCountry", "AdresseNumero", "AdresseNumeroBoite", "AdresseRue", "AdresseVille", "Email", "Nom", "Password", "PhoneNumber", "Prenom" },
                values: new object[] { 9, 1000, "Belgique", 90, 9, "Avenue des Arts", "Bruxelles", "nathalie.petit@example.com", "Petit", "password123", 497987654, "Nathalie" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "IDutilisateur",
                keyValue: 9);
        }
    }
}
