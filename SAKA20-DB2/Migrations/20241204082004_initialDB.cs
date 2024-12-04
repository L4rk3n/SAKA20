using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAKA20_DB2.Migrations
{
    /// <inheritdoc />
    public partial class initialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    IDutilisateur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Admin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Activated = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    AdresseRue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresseNumero = table.Column<int>(type: "int", nullable: false),
                    AdresseCodePostal = table.Column<int>(type: "int", nullable: false),
                    AdresseVille = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresseNumeroBoite = table.Column<int>(type: "int", nullable: false),
                    AdresseCountry = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.IDutilisateur);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
