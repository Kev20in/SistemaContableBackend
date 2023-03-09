using APEC.ProyectoFinal.API.Entities;
using APEC.ProyectoFinal.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace APEC.ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrearTipoCuentaContableController : ControllerBase
    {
        private readonly ISuperService _superService;

        public CrearTipoCuentaContableController(ISuperService superService)
        {
            _superService = superService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTipoCuentaContable()
        {
            return Ok(await _superService.GetAllTipoCuentaContable());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTipoCuentaContableById(int id)
        {
            return Ok(await _superService.GetTipoCuentaContableById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CrearTipoCuentaContable([FromBody] TipoCuentaContable tipoMoneda)
        {
            return Ok(await _superService.CrearTipoCuentaContable(tipoMoneda));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTipoCuentaContable([FromBody] TipoCuentaContable cuentaContable)
        {
            await _superService.UpdateTipoCuentaContable(cuentaContable);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> BorrarTipoCuentaContable(int id)
        {
            await _superService.BorrarTipoCuentaContable(id);

            return NoContent();
        }
    }
}