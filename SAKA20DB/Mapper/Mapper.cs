
using EU = SAKA20_DB.Entities;
using EU2 = SAKA20_DB2.Entities;
using BLL = SAKA20_BLL.Entities;

namespace SAKA20_BLL.Mapper
{
    public static class Mapper
{
        public static EU.Utilisateur ToEU(this BLL.Utilisateur entity)
        {
            return new EU.Utilisateur
            {
               IDutilisateur = entity.IDutilisateur, 
               Nom = entity.Nom,
               Prenom = entity.Prenom,
               Email = entity.Email,
               Password = entity.Password,
               PhoneNumber = entity.PhoneNumber,
               Admin = entity.Admin,
               Activated = entity.Activated,
               Cancelled = entity.Cancelled,
               AdresseRue = entity.AdresseRue,
               AdresseNumero = entity.AdresseNumero,
               AdresseCodePostal = entity.AdresseCodePostal,
               AdresseVille = entity.AdresseVille,
               AdresseNumeroBoite = entity.AdresseNumeroBoite,
               AdresseCountry = entity.AdresseCountry,

            };
        }

        public static BLL.Utilisateur ToBLL(this EU.Utilisateur entity)
        {
            return new BLL.Utilisateur
            {
                IDutilisateur = entity.IDutilisateur,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Password = entity.Password,
                PhoneNumber = entity.PhoneNumber,
                Admin = entity.Admin,
                Activated = entity.Activated,
                Cancelled = entity.Cancelled,
                AdresseRue = entity.AdresseRue,
                AdresseNumero = entity.AdresseNumero,
                AdresseCodePostal = entity.AdresseCodePostal,
                AdresseVille = entity.AdresseVille,
                AdresseNumeroBoite = entity.AdresseNumeroBoite,
                AdresseCountry = entity.AdresseCountry,

            };
        }

        public static EU2.Vin ToEU2(this BLL.Vin entity)
        {
            return new EU2.Vin
            {
                Idvin = entity.Idvin,
                Nom = entity.Nom,
                Fournisseur = entity.Fournisseur,
                Cuvee = entity.Cuvee,
                Type = entity.Type,
                Format = entity.Format,
                Disponible = entity.Disponible,
                Stock = entity.Stock,
                Empalpha = entity.Empalpha,
                Empnum = entity.Empnum,
                Prix = entity.Prix,
                Prixtva = entity.Prixtva,

            };  
        }

        public static BLL.Vin ToBLL(this EU2.Vin entity)
        {
            return new BLL.Vin
            {
                Idvin = entity.Idvin,
                Nom = entity.Nom,
                Fournisseur = entity.Fournisseur,
                Cuvee = entity.Cuvee,
                Type = entity.Type,
                Format = entity.Format,
                Disponible = entity.Disponible,
                Stock = entity.Stock,
                Empalpha = entity.Empalpha,
                Empnum = entity.Empnum,
                Prix = entity.Prix,
                Prixtva = entity.Prixtva,

            };
        }
    }
}
