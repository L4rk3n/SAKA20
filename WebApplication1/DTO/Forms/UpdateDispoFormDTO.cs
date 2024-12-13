using System.ComponentModel.DataAnnotations;

namespace SAKA20_API.DTO.Forms
{
    public class UpdateDispoFormDTO
    {
        [Required]
        public bool Disponible { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}
