using Microsoft.AspNetCore.Mvc;
using SAKA20_API.DTO.Forms;
using SAKA20_Common.Repositories;
using SAKA20_BLL.Entities;
using SAKA20_API.Tools;

namespace SAKA20_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IUtilisateurRepository<Utilisateur, int, string> _UtilisateurService;

        public AdminController(IUtilisateurRepository<Utilisateur, int, string> UtilisateurService)
        {
            _UtilisateurService = UtilisateurService;
        }

        [HttpPut]
        public IActionResult UpdateAccess(int id, [FromBody] namelessaccessFormDTO accessupdated)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                _UtilisateurService.UpdateAccess(id, accessupdated.namelessToBLL());
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_UtilisateurService.Get().Select(u => u.accessToAPI()));
        }

    }
}
