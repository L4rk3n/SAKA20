using BLL = SAKA20_BLL.Entities;

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
    }
}
