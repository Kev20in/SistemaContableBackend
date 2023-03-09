using APEC.ProyectoFinal.API.Entities;
using APEC.ProyectoFinal.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace APEC.ProyectoFinal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaContableController : ControllerBase
    {
        private readonly ISuperService _superService;

        public CuentaContableController(ISuperService superService)
        {
            _superService = superService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCuentaContableListAsync()
        {
            return Ok(await _superService.GetTipoCuentaContable());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCuentaContableByIdAsync(int id)
        {
            return Ok(await _superService.GetCuentaContableById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCuentaContableListAsync([FromBody] CuentaContable cuentaContable)
        {
            return Ok(await _superService.CrearCuentaContable(cuentaContable));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCuentaContableListAsync([FromBody] CuentaContable cuentaContable)
        {
            await _superService.UpdateCuentaContable(cuentaContable);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCuentaContableListAsync(int id)
        {
            await _superService.BorrarCuentaContable(id);

            return NoContent();
        }
    }
}