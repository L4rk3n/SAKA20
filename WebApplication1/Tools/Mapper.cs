﻿using BLL = SAKA20_BLL.Entities;

namespace SAKA20_API.Tools

{
    public static class Mapper
    {
        public static DTO.Forms.UtilisateurFormDTO ToAPI(this BLL.Utilisateur entity)
        {
            return new DTO.Forms.UtilisateurFormDTO
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

        public static BLL.Utilisateur ToBLL(this DTO.Forms.UtilisateurFormDTO entity)
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

        public static DTO.Forms.profileupdatedDTO UpdateToAPI(this BLL.Utilisateur entity)
        {
            return new DTO.Forms.profileupdatedDTO
            {

                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
                AdresseRue = entity.AdresseRue,
                AdresseNumero = entity.AdresseNumero,
                AdresseCodePostal = entity.AdresseCodePostal,
                AdresseVille = entity.AdresseVille,
                AdresseNumeroBoite = entity.AdresseNumeroBoite,
                AdresseCountry = entity.AdresseCountry,
                

            };
        }

        public static BLL.Utilisateur UpdateToBLL(this DTO.Forms.profileupdatedDTO entity)
        {
            return new BLL.Utilisateur
            {


                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
                AdresseRue = entity.AdresseRue,
                AdresseNumero = entity.AdresseNumero,
                AdresseCodePostal = entity.AdresseCodePostal,
                AdresseVille = entity.AdresseVille,
                AdresseNumeroBoite = entity.AdresseNumeroBoite,
                AdresseCountry = entity.AdresseCountry,
                
            };
        }

        public static DTO.Forms.accessFormDTO accessToAPI(this BLL.Utilisateur entity)
        {
            return new DTO.Forms.accessFormDTO
            {
                IDutilisateur = entity.IDutilisateur,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Admin = entity.Admin,
                Activated = entity.Activated,
                Cancelled = entity.Cancelled,


            };
        }

        public static BLL.Utilisateur accessToBLL(this DTO.Forms.accessFormDTO entity)
        {
            return new BLL.Utilisateur
            {

                IDutilisateur = entity.IDutilisateur,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Admin = entity.Admin,
                Activated = entity.Activated,
                Cancelled = entity.Cancelled,

            };
        }

        public static DTO.Forms.namelessaccessFormDTO namelessToAPI(this BLL.Utilisateur entity)
        {
            return new DTO.Forms.namelessaccessFormDTO
            {

                
                Admin = entity.Admin,
                Activated = entity.Activated,
                Cancelled = entity.Cancelled,


            };
        }

        public static BLL.Utilisateur namelessToBLL(this DTO.Forms.namelessaccessFormDTO entity)
        {
            return new BLL.Utilisateur
            {
            
                Admin = entity.Admin,
                Activated = entity.Activated,
                Cancelled = entity.Cancelled,

            };
        }

        public static DTO.Forms.VinFormDTO vinToAPI(this BLL.Vin entity)
        {
            return new DTO.Forms.VinFormDTO
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

        public static BLL.Vin vinToBLL(this DTO.Forms.VinFormDTO entity)
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

        public static DTO.Forms.UpdateVinFormDTO updatevinToAPI(this BLL.Vin entity)
        {
            return new DTO.Forms.UpdateVinFormDTO
            {

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

        public static BLL.Vin updatevinToBLL(this DTO.Forms.UpdateVinFormDTO entity)
        {
            return new BLL.Vin
            {

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

        public static DTO.Forms.UpdateDispoFormDTO dispoToAPI(this BLL.Vin entity)
        {
            return new DTO.Forms.UpdateDispoFormDTO
            {

                Disponible = entity.Disponible,
                Stock = entity.Stock,

            };
        }

        public static BLL.Vin dispoToBLL(this DTO.Forms.UpdateDispoFormDTO entity)
        {
            return new BLL.Vin
            {

                Disponible = entity.Disponible,
                Stock = entity.Stock,

            };
        }

    }
}
