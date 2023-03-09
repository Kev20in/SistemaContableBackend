using APEC.ProyectoFinal.API.Entities;

namespace APEC.ProyectoFinal.API.Services
{
    public interface ISuperService
    {
        Task BorrarCuentaContable(int id);
        Task BorrarEntradaCuentaContable(int id);
        Task BorrarSistemaAuxiliares(int id);
        Task BorrarTipoCuentaContable(int id);
        Task BorrarTipoMoneda(int id);
        Task<CuentaContable> CrearCuentaContable(CuentaContable tipoMoneda);
        Task<EntradaContable> CrearEntradaCuentaContable(EntradaContable entradaCuentaContable);
        Task<SistemaAuxiliares> CrearSistemaAuxiliares(SistemaAuxiliares tipoMoneda);
        Task<TipoCuentaContable> CrearTipoCuentaContable(TipoCuentaContable tipoMoneda);
        Task<TipoMoneda> CrearTipoMoneda(TipoMoneda tipoMoneda);
        Task<List<TipoCuentaContable>> GetAllTipoCuentaContable();
        Task<List<TipoMoneda>> GetAllTipoMoneda();
        Task<CuentaContable> GetCuentaContableById(int id);
        Task<List<EntradaContable>> GetEntradaCuentaContable();
        Task<EntradaContable> GetEntradaCuentaContableById(int id);
        Task<List<SistemaAuxiliares>> GetSistemaAuxiliares();
        Task<SistemaAuxiliares> GetSistemaAuxiliaresById(int id);
        Task<List<CuentaContable>> GetTipoCuentaContable();
        Task<TipoCuentaContable> GetTipoCuentaContableById(int id);
        Task<TipoMoneda> GetTipoMonedaById(int id);
        Task UpdateCuentaContable(CuentaContable tipoCuentaContable);
        Task UpdateEntradaCuentaContable(EntradaContable entradaCuentaContable);
        Task UpdateSistemaAuxiliares(SistemaAuxiliares tipoCuentaContable);
        Task UpdateTipoCuentaContable(TipoCuentaContable tipoCuentaContable);
        Task UpdateTipoMoneda(TipoMoneda tipoMoneda);
    }
}