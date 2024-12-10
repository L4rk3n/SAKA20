using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAKA20_API.DTO.Forms;
using SAKA20_Common.Repositories;
using SAKA20_BLL.Entities;
using SAKA20_API.Tools;
using SAKA20_BLL.Services;

namespace SAKA20_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {

        private readonly IUtilisateurRepository<Utilisateur, int, string> _UtilisateurService;

        public UtilisateurController(IUtilisateurRepository<Utilisateur, int, string> UtilisateurService)
        {
            _UtilisateurService = UtilisateurService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_UtilisateurService.Get());
        }

        [HttpPost]
        public IActionResult Create([FromBody] UtilisateurFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            else
            {
                return Ok(_UtilisateurService.Create(form.ToBLL()));
            }
        }

        [HttpGet("byUtilisateurs/{id}")]
        public IActionResult GetByUtilisateursId(int id)
        {
            return Ok(_UtilisateurService.Get(id));
        }

        [HttpGet("byEmail/{email}")]
        public IActionResult GetByemail(string email)
        {
            return Ok(_UtilisateurService.Get(email));
        }

        [HttpPost("updatepassword")]
        public async Task<IActionResult> UpdateAsync([FromBody] OldNewPasswordDTO form)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _UtilisateurService.UpdatePasswordAsync(form.IDutilisateur,form.OldPassword,form.NewPassword);
            if (!result) 
                { return Unauthorized("L'ancien mot de passe est incorrect."); }
            return Ok(result);  
        }
    }
}

