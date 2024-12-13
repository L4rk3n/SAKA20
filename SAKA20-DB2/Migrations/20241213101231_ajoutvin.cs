using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SAKA20_DB2.Migrations
{
    /// <inheritdoc />
    public partial class ajoutvin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vin",
                columns: table => new
                {
                    Idvin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cuvee = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Format = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fournisseur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Empalpha = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Empnum = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<int>(type: "int", nullable: false),
                    Prixtva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vin", x => x.Idvin);
                });

            migrationBuilder.InsertData(
                table: "Vin",
                columns: new[] { "Idvin", "Cuvee", "Disponible", "Empalpha", "Empnum", "Format", "Fournisseur", "Nom", "Prix", "Prixtva", "Stock", "Type" },
                values: new object[,]
                {
                    { 1, 2015, true, "AA", 1, "75cl", "Vins & Co", "Château Margaux", 250, 300, 50, "Rouge" },
                    { 2, 2016, true, "AB", 2, "75cl", "Vins & Co", "Domaine de la Romanée-Conti", 500, 600, 20, "Rouge" },
                    { 3, 2014, false, "AC", 3, "75cl", "Les Domaines Français", "Pétrus", 700, 850, 0, "Rouge" },
                    { 4, 2017, true, "AD", 4, "75cl", "Les Domaines Français", "Château Lafite Rothschild", 450, 540, 30, "Rouge" },
                    { 5, 2018, true, "AE", 5, "75cl", "Cave de Luxe", "Opus One", 400, 480, 15, "Rouge" },
                    { 6, 2015, true, "AF", 6, "75cl", "Cave de Luxe", "Sassicaia", 300, 360, 25, "Rouge" },
                    { 7, 2013, false, "AG", 7, "75cl", "Les Domaines Français", "Château d'Yquem", 600, 720, 0, "Blanc" },
                    { 8, 2016, true, "AH", 8, "75cl", "Cave de Luxe", "Penfolds Grange", 350, 420, 35, "Rouge" },
                    { 9, 2014, true, "AI", 9, "75cl", "Vins & Co", "Vega Sicilia", 480, 570, 40, "Rouge" },
                    { 10, 2017, true, "AJ", 10, "75cl", "Les Domaines Français", "Château Latour", 550, 660, 45, "Rouge" },
                    { 11, 2015, false, "AK", 1, "75cl", "Vins & Co", "Domaine Leflaive", 650, 780, 0, "Blanc" },
                    { 12, 2016, true, "AL", 2, "75cl", "Cave de Luxe", "Château Haut-Brion", 430, 516, 28, "Rouge" },
                    { 13, 2018, true, "AM", 3, "75cl", "Les Domaines Français", "Almaviva", 270, 324, 32, "Rouge" },
                    { 14, 2017, true, "AN", 4, "75cl", "Vins & Co", "Guigal La Landonne", 380, 456, 22, "Rouge" },
                    { 15, 2016, false, "AO", 5, "75cl", "Cave de Luxe", "Masseto", 710, 852, 0, "Rouge" },
                    { 16, 2014, true, "AP", 6, "75cl", "Les Domaines Français", "Château Palmer", 340, 408, 37, "Rouge" },
                    { 17, 2018, true, "AQ", 7, "75cl", "Vins & Co", "Château Mouton Rothschild", 460, 552, 33, "Rouge" },
                    { 18, 2015, true, "AR", 8, "75cl", "Cave de Luxe", "Tignanello", 320, 384, 30, "Rouge" },
                    { 19, 2017, true, "AS", 9, "75cl", "Les Domaines Français", "La Tâche", 540, 648, 27, "Rouge" },
                    { 20, 2016, false, "AT", 10, "75cl", "Vins & Co", "Screaming Eagle", 800, 960, 5, "Rouge" },
                    { 21, 2018, true, "AU", 1, "75cl", "Les Domaines Français", "Chablis Grand Cru", 220, 264, 50, "Blanc" },
                    { 22, 2019, true, "AV", 2, "75cl", "Cave de Luxe", "Puligny-Montrachet", 300, 360, 25, "Blanc" },
                    { 23, 2017, true, "AW", 3, "75cl", "Vins & Co", "Riesling Grand Cru", 180, 216, 40, "Blanc" },
                    { 24, 2016, true, "AX", 4, "62cl", "Les Domaines Français", "Vin Jaune d'Arbois", 450, 540, 20, "Jaune" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vin");
        }
    }
}
