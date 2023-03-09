using APEC.ProyectoFinal.API.Entities;
using APEC.ProyectoFinal.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace APEC.ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemasAuxiliaresController : ControllerBase
    {
        private readonly ISuperService _superService;

        public SistemasAuxiliaresController(ISuperService superService)
        {
            _superService = superService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSistemaAuxiliares()
        {
            return Ok(await _superService.GetSistemaAuxiliares());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetSistemaAuxiliaresById(int id)
        {
            return Ok(await _superService.GetSistemaAuxiliaresById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CrearSistemaAuxiliares([FromBody] SistemaAuxiliares tipoMoneda)
        {
            return Ok(await _superService.CrearSistemaAuxiliares(tipoMoneda));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSistemaAuxiliares([FromBody] SistemaAuxiliares cuentaContable)
        {
            await _superService.UpdateSistemaAuxiliares(cuentaContable);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> BorrarSistemaAuxiliares(int id)
        {
            await _superService.BorrarSistemaAuxiliares(id);

            return NoContent();
        }
    }
}