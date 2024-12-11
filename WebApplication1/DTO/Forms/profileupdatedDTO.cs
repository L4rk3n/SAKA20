using System.ComponentModel.DataAnnotations;

namespace SAKA20_API.DTO.Forms
{
    public class profileupdatedDTO
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string AdresseRue { get; set; }
        [Required]
        public int AdresseNumero { get; set; }
        [Required]
        public int AdresseCodePostal { get; set; }
        [Required]
        public string AdresseVille { get; set; }

        public int AdresseNumeroBoite { get; set; }
        [Required]
        public string AdresseCountry { get; set; }

    }
}
