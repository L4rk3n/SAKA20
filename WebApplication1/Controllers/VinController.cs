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
    public class VinController :ControllerBase
    {
        private readonly IVinRepository<Vin, int> _VinService;

        public VinController(IVinRepository<Vin, int> VinService)
        {
            _VinService = VinService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_VinService.Get().Select(u => u.vinToAPI()));
        }

        [HttpPost]
        public IActionResult Create([FromBody] UpdateVinFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            else
            {
                return Ok(_VinService.Create(form.updatevinToBLL()));
            }
        }

        [HttpGet("byVin/{id}")]
        public IActionResult GetByVinId(int id)
        {
            return Ok(_VinService.Get(id).vinToAPI());
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVin(int id, [FromBody] UpdateVinFormDTO UpdateVin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                _VinService.Update(id, UpdateVin.updatevinToBLL());
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        [HttpPut("Dispo")]
        public IActionResult UpdateDispo(int id, [FromBody] UpdateDispoFormDTO UpdateDispo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                _VinService.Update(id, UpdateDispo.dispoToBLL());
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

    }
}
