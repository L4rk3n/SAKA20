using System.ComponentModel.DataAnnotations;

namespace SAKA20_API.DTO.Forms
{
    public class accessFormDTO
    {
        [Required]
        public int IDutilisateur { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public bool Admin { get; set; }
        [Required]
        public bool Activated { get; set; }
        [Required]
        public bool Cancelled { get; set; }

    }
}
