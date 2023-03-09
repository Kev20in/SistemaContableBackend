using APEC.ProyectoFinal.API.Entities;
using APEC.ProyectoFinal.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace APEC.ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoMonedaController : ControllerBase
    {
        private readonly ISuperService _superService;

        public TipoMonedaController(ISuperService superService)
        {
            _superService = superService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTipoMonedaListAsync()
        {
            return Ok(await _superService.GetAllTipoMoneda());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTipoMonedaById(int id)
        {
            return Ok(await _superService.GetTipoMonedaById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CrearTipoMoneda([FromBody] TipoMoneda tipoMoneda)
        {
            return Ok(await _superService.CrearTipoMoneda(tipoMoneda));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTipoMoneda([FromBody] TipoMoneda cuentaContable)
        {
            await _superService.UpdateTipoMoneda(cuentaContable);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> BorrarTipoMoneda(int id)
        {
            await _superService.BorrarTipoMoneda(id);

            return NoContent();
        }
    }
}