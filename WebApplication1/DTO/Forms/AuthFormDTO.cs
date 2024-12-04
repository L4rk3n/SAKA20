using System.ComponentModel.DataAnnotations;

namespace SAKA20_API.DTO.Forms
{
        public class AuthFormDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
