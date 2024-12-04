using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAKA20_API.DTO.Forms;
using SAKA20_Common.Repositories;
using SAKA20_BLL.Entities;
using SAKA20_API.Tools;

namespace SAKA20_API.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public class UtilisateurController : ControllerBase
        {

            private readonly IUtilisateurRepository<Utilisateur, int,string> _UtilisateurService;

            public UtilisateurController(IUtilisateurRepository<Utilisateur, int,string> UtilisateurService)
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

                try
                {
                    _UtilisateurService.Create(form.ToBLL());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                return Ok();
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
        }
    }

