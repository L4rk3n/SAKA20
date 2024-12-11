using System.ComponentModel.DataAnnotations;

namespace SAKA20_API.DTO.Forms
{
    public class namelessaccessFormDTO
    {
        [Required]
        public bool Admin { get; set; }
        [Required]
        public bool Activated { get; set; }
        [Required]
        public bool Cancelled { get; set; }
    }
}
