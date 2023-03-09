using APEC.ProyectoFinal.API.Entities;
using APEC.ProyectoFinal.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace APEC.ProyectoFinal.API.Services
{
    public class SuperService : ISuperService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SuperService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region TipoMoneda

        public async Task<TipoMoneda> CrearTipoMoneda(TipoMoneda tipoMoneda)
        {
            var result = await _unitOfWork.TipoMoneda.Add(tipoMoneda);
            await _unitOfWork.CompleteAsync();
            return result;
        }

        public async Task UpdateTipoMoneda(TipoMoneda tipoMoneda)
        {
            _unitOfWork.TipoMoneda.Update(tipoMoneda);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<TipoMoneda> GetTipoMonedaById(int id)
        {
            return await _unitOfWork.TipoMoneda.Get(id);
        }

        public async Task<List<TipoMoneda>> GetAllTipoMoneda()
        {
            return await _unitOfWork.TipoMoneda.GetAll().ToListAsync();
        }

        public async Task BorrarTipoMoneda(int id)
        {
            var tipoMoneda = await GetTipoMonedaById(id);
            _unitOfWork.TipoMoneda.Delete(tipoMoneda);
            await _unitOfWork.CompleteAsync();
        }

        #endregion TipoMoneda

        #region TipoCuentaContable

        public async Task<TipoCuentaContable> CrearTipoCuentaContable(TipoCuentaContable tipoMoneda)
        {
            var result = await _unitOfWork.TipoCuentaContable.Add(tipoMoneda);
            await _unitOfWork.CompleteAsync();
            return result;
        }

        public async Task UpdateTipoCuentaContable(TipoCuentaContable tipoCuentaContable)
        {
            _unitOfWork.TipoCuentaContable.Update(tipoCuentaContable);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<TipoCuentaContable> GetTipoCuentaContableById(int id)
        {
            return await _unitOfWork.TipoCuentaContable.Get(id);
        }

        public async Task<List<TipoCuentaContable>> GetAllTipoCuentaContable()
        {
            return await _unitOfWork.TipoCuentaContable.GetAll().ToListAsync();
        }

        public async Task BorrarTipoCuentaContable(int id)
        {
            var tipoCuentaContable = await GetTipoCuentaContableById(id);
            _unitOfWork.TipoCuentaContable.Delete(tipoCuentaContable);
            await _unitOfWork.CompleteAsync();
        }

        #endregion TipoCuentaContable

        #region CuentaContable

        public async Task<CuentaContable> CrearCuentaContable(CuentaContable tipoMoneda)
        {
            var result = await _unitOfWork.CuentaContable.Add(tipoMoneda);
            await _unitOfWork.CompleteAsync();
            return result;
        }

        public async Task UpdateCuentaContable(CuentaContable tipoCuentaContable)
        {
            _unitOfWork.CuentaContable.Update(tipoCuentaContable);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<CuentaContable> GetCuentaContableById(int id)
        {
            return await _unitOfWork.CuentaContable.Get(id);
        }

        public async Task<List<CuentaContable>> GetTipoCuentaContable()
        {
            return await _unitOfWork.CuentaContable.GetAll().ToListAsync();
        }

        public async Task BorrarCuentaContable(int id)
        {
            var cuentaContable = await GetTipoCuentaContableById(id);
            _unitOfWork.TipoCuentaContable.Delete(cuentaContable);
            await _unitOfWork.CompleteAsync();
        }

        #endregion CuentaContable

        #region SistemaAuxiliares

        public async Task<SistemaAuxiliares> CrearSistemaAuxiliares(SistemaAuxiliares tipoMoneda)
        {
            var result = await _unitOfWork.SistemaAuxiliares.Add(tipoMoneda);
            await _unitOfWork.CompleteAsync();
            return result;
        }

        public async Task UpdateSistemaAuxiliares(SistemaAuxiliares tipoCuentaContable)
        {
            _unitOfWork.SistemaAuxiliares.Update(tipoCuentaContable);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<SistemaAuxiliares> GetSistemaAuxiliaresById(int id)
        {
            return await _unitOfWork.SistemaAuxiliares.Get(id);
        }

        public async Task<List<SistemaAuxiliares>> GetSistemaAuxiliares()
        {
            return await _unitOfWork.SistemaAuxiliares.GetAll().ToListAsync();
        }

        public async Task BorrarSistemaAuxiliares(int id)
        {
            var cuentaContable = await GetSistemaAuxiliaresById(id);
            _unitOfWork.SistemaAuxiliares.Delete(cuentaContable);
            await _unitOfWork.CompleteAsync();
        }

        #endregion SistemaAuxiliares

        #region EntradaContable

        public async Task<EntradaContable> CrearEntradaCuentaContable(EntradaContable entradaCuentaContable)
        {
            var result = await _unitOfWork.EntradaCuentaContable.Add(entradaCuentaContable);

            var cuentaContable = await GetCuentaContableById(result.CuentaContableId);

            cuentaContable.Balance = +result.MontoAsiento;

            await UpdateCuentaContable(cuentaContable);

            await _unitOfWork.CompleteAsync();

            return result;
        }

        public async Task UpdateEntradaCuentaContable(EntradaContable entradaCuentaContable)
        {
            _unitOfWork.EntradaCuentaContable.Update(entradaCuentaContable);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<EntradaContable> GetEntradaCuentaContableById(int id)
        {
            return await _unitOfWork.EntradaCuentaContable.Get(id);
        }

        public async Task<List<EntradaContable>> GetEntradaCuentaContable()
        {
            return await _unitOfWork.EntradaCuentaContable.GetAll().ToListAsync();
        }

        public async Task BorrarEntradaCuentaContable(int id)
        {
            var entradaCuentaContable = await GetEntradaCuentaContableById(id);
            _unitOfWork.EntradaCuentaContable.Delete(entradaCuentaContable);
            await _unitOfWork.CompleteAsync();
        }

        #endregion EntradaContable
    }
}