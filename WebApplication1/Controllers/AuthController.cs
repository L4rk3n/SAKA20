using Microsoft.AspNetCore.Mvc;

using SAKA20_Common.Repositories;
using SAKA20_BLL.Entities;
using SAKA20_API.DTO.Forms;
using SAKA20_API.Services;

namespace SAKA20_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUtilisateurRepository<Utilisateur, int, string> _UtilisateurService;

        private readonly TokenService _tokenService;

        public AuthController(IUtilisateurRepository<Utilisateur, int, string> utilisateurService, TokenService tokenService)
        {
            _UtilisateurService = utilisateurService;
            _tokenService = tokenService;
        }



        [HttpPost]
        public IActionResult Login(AuthFormDTO authFormDTO)
        {

            Utilisateur? utilisateur = _UtilisateurService.Get(authFormDTO.Email);

            if (utilisateur is null)
                return BadRequest();

            if (authFormDTO.Password != utilisateur.Password)
                return BadRequest();
            if (utilisateur.Cancelled == true )
                return BadRequest();

            // to do generer le token a renvoyer dans le ok 
            return Ok(new { token = _tokenService.GenerateJwt(utilisateur) });

        }
    }
}
