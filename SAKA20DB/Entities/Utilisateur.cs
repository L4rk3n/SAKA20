﻿
using SAKA20_Common.Entities;

namespace SAKA20_BLL.Entities
{
    public class Utilisateur : IUtilisateur
    {
        public int IDutilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public bool Admin { get; set; }
        public bool Activated { get; set; }
        public bool Cancelled { get; set; }
        public string AdresseRue { get; set; }
        public int AdresseNumero { get; set; }
        public int AdresseCodePostal { get; set; }
        public string AdresseVille { get; set; }
        public int AdresseNumeroBoite { get; set; }
        public string AdresseCountry { get; set; }
    }
}
