using System.ComponentModel.DataAnnotations;

namespace SAKA20_API.DTO.Forms
{
    public class UpdateVinFormDTO
    {

        [Required]
        public string Nom { get; set; }

        [Required]
        public int Cuvee { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Format { get; set; }

        [Required]
        public string Fournisseur { get; set; }

        [Required]
        public bool Disponible { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public string Empalpha { get; set; }

        [Required]
        public int Empnum { get; set; }

        [Required]
        public int Prix { get; set; }

        [Required]
        public int Prixtva { get; set; }
    }
}
