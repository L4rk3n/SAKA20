using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAKA20_DB2.Entities;

namespace SAKA20_DB2.Config
{
    public class VinDataSet : IEntityTypeConfiguration<Vin>
    {
        public void Configure(EntityTypeBuilder<Vin> builder)
        {
            builder.HasData(
               
            new Vin { Idvin = 1, Nom = "Château Margaux", Cuvee = 2015, Type = "Rouge", Format = "75cl", Fournisseur = "Vins & Co", Disponible = true, Stock = 50, Empalpha = "AA", Empnum = 01, Prix = 250, Prixtva = 300 },
            new Vin { Idvin = 2, Nom = "Domaine de la Romanée-Conti", Cuvee = 2016, Type = "Rouge", Format = "75cl", Fournisseur = "Vins & Co", Disponible = true, Stock = 20, Empalpha = "AB", Empnum = 02, Prix = 500, Prixtva = 600 },
            new Vin { Idvin = 3, Nom = "Pétrus", Cuvee = 2014, Type = "Rouge", Format = "75cl", Fournisseur = "Les Domaines Français", Disponible = false, Stock = 0, Empalpha = "AC", Empnum = 03, Prix = 700, Prixtva = 850 },
            new Vin { Idvin = 4, Nom = "Château Lafite Rothschild", Cuvee = 2017, Type = "Rouge", Format = "75cl", Fournisseur = "Les Domaines Français", Disponible = true, Stock = 30, Empalpha = "AD", Empnum = 04, Prix = 450, Prixtva = 540 },
            new Vin { Idvin = 5, Nom = "Opus One", Cuvee = 2018, Type = "Rouge", Format = "75cl", Fournisseur = "Cave de Luxe", Disponible = true, Stock = 15, Empalpha = "AE", Empnum = 05, Prix = 400, Prixtva = 480 },
            new Vin { Idvin = 6, Nom = "Sassicaia", Cuvee = 2015, Type = "Rouge", Format = "75cl", Fournisseur = "Cave de Luxe", Disponible = true, Stock = 25, Empalpha = "AF", Empnum = 06, Prix = 300, Prixtva = 360 },
            new Vin { Idvin = 7, Nom = "Château d'Yquem", Cuvee = 2013, Type = "Blanc", Format = "75cl", Fournisseur = "Les Domaines Français", Disponible = false, Stock = 0, Empalpha = "AG", Empnum = 07, Prix = 600, Prixtva = 720 },
            new Vin { Idvin = 8, Nom = "Penfolds Grange", Cuvee = 2016, Type = "Rouge", Format = "75cl", Fournisseur = "Cave de Luxe", Disponible = true, Stock = 35, Empalpha = "AH", Empnum = 08, Prix = 350, Prixtva = 420 },
            new Vin { Idvin = 9, Nom = "Vega Sicilia", Cuvee = 2014, Type = "Rouge", Format = "75cl", Fournisseur = "Vins & Co", Disponible = true, Stock = 40, Empalpha = "AI", Empnum = 09, Prix = 480, Prixtva = 570 },
            new Vin { Idvin = 10, Nom = "Château Latour", Cuvee = 2017, Type = "Rouge", Format = "75cl", Fournisseur = "Les Domaines Français", Disponible = true, Stock = 45, Empalpha = "AJ", Empnum = 10, Prix = 550, Prixtva = 660 },
            new Vin { Idvin = 11, Nom = "Domaine Leflaive", Cuvee = 2015, Type = "Blanc", Format = "75cl", Fournisseur = "Vins & Co", Disponible = false, Stock = 0, Empalpha = "AK", Empnum = 01, Prix = 650, Prixtva = 780 },
            new Vin { Idvin = 12, Nom = "Château Haut-Brion", Cuvee = 2016, Type = "Rouge", Format = "75cl", Fournisseur = "Cave de Luxe", Disponible = true, Stock = 28, Empalpha = "AL", Empnum = 02, Prix = 430, Prixtva = 516 },
            new Vin { Idvin = 13, Nom = "Almaviva", Cuvee = 2018, Type = "Rouge", Format = "75cl", Fournisseur = "Les Domaines Français", Disponible = true, Stock = 32, Empalpha = "AM", Empnum = 03, Prix = 270, Prixtva = 324 },
            new Vin { Idvin = 14, Nom = "Guigal La Landonne", Cuvee = 2017, Type = "Rouge", Format = "75cl", Fournisseur = "Vins & Co", Disponible = true, Stock = 22, Empalpha = "AN", Empnum = 04, Prix = 380, Prixtva = 456 },
            new Vin { Idvin = 15, Nom = "Masseto", Cuvee = 2016, Type = "Rouge", Format = "75cl", Fournisseur = "Cave de Luxe", Disponible = false, Stock = 0, Empalpha = "AO", Empnum = 05, Prix = 710, Prixtva = 852 },
            new Vin { Idvin = 16, Nom = "Château Palmer", Cuvee = 2014, Type = "Rouge", Format = "75cl", Fournisseur = "Les Domaines Français", Disponible = true, Stock = 37, Empalpha = "AP", Empnum = 06, Prix = 340, Prixtva = 408 },
            new Vin { Idvin = 17, Nom = "Château Mouton Rothschild", Cuvee = 2018, Type = "Rouge", Format = "75cl", Fournisseur = "Vins & Co", Disponible = true, Stock = 33, Empalpha = "AQ", Empnum = 07, Prix = 460, Prixtva = 552 },
            new Vin { Idvin = 18, Nom = "Tignanello", Cuvee = 2015, Type = "Rouge", Format = "75cl", Fournisseur = "Cave de Luxe", Disponible = true, Stock = 30, Empalpha = "AR", Empnum = 08, Prix = 320, Prixtva = 384 },
            new Vin { Idvin = 19, Nom = "La Tâche", Cuvee = 2017, Type = "Rouge", Format = "75cl", Fournisseur = "Les Domaines Français", Disponible = true, Stock = 27, Empalpha = "AS", Empnum = 09, Prix = 540, Prixtva = 648 },
            new Vin { Idvin = 20, Nom = "Screaming Eagle", Cuvee = 2016, Type = "Rouge", Format = "75cl", Fournisseur = "Vins & Co", Disponible = false, Stock = 5, Empalpha = "AT", Empnum = 10, Prix = 800, Prixtva = 960 },
            new Vin { Idvin = 21, Nom = "Chablis Grand Cru", Cuvee = 2018, Type = "Blanc", Format = "75cl", Fournisseur = "Les Domaines Français", Disponible = true, Stock = 50, Empalpha = "AU", Empnum = 01, Prix = 220, Prixtva = 264 },
            new Vin { Idvin = 22, Nom = "Puligny-Montrachet", Cuvee = 2019, Type = "Blanc", Format = "75cl", Fournisseur = "Cave de Luxe", Disponible = true, Stock = 25, Empalpha = "AV", Empnum = 02, Prix = 300, Prixtva = 360 },
            new Vin { Idvin = 23, Nom = "Riesling Grand Cru", Cuvee = 2017, Type = "Blanc", Format = "75cl", Fournisseur = "Vins & Co", Disponible = true, Stock = 40, Empalpha = "AW", Empnum = 03, Prix = 180, Prixtva = 216 },
            new Vin { Idvin = 24, Nom = "Vin Jaune d'Arbois", Cuvee = 2016, Type = "Jaune", Format = "62cl", Fournisseur = "Les Domaines Français", Disponible = true, Stock = 20, Empalpha = "AX", Empnum = 04, Prix = 450, Prixtva = 540 }
            );
        }

    }
}