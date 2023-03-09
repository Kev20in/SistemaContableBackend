using APEC.ProyectoFinal.API.Entities;
using APEC.ProyectoFinal.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace APEC.ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaContableController : ControllerBase
    {
        private readonly ISuperService _superService;

        public EntradaContableController(ISuperService superService)
        {
            _superService = superService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEntradaCuentaContable()
        {
            return Ok(await _superService.GetEntradaCuentaContable());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEntradaCuentaContableById(int id)
        {
            return Ok(await _superService.GetEntradaCuentaContableById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CrearEntradaCuentaContable([FromBody] EntradaContable tipoMoneda)
        {
            return Ok(await _superService.CrearEntradaCuentaContable(tipoMoneda));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEntradaCuentaContable([FromBody] EntradaContable cuentaContable)
        {
            await _superService.UpdateEntradaCuentaContable(cuentaContable);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> BorrarEntradaCuentaContable(int id)
        {
            await _superService.BorrarEntradaCuentaContable(id);

            return NoContent();
        }
    }
}