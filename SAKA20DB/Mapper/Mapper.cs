using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EU = SAKA20_DB.Entities;
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
    }
}
