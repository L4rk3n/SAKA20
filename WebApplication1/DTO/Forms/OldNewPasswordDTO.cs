using System.ComponentModel.DataAnnotations;

namespace SAKA20_API.DTO.Forms
{
        public class OldNewPasswordDTO
    {
        [Required]
        public int IDutilisateur { get; set; }
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}
