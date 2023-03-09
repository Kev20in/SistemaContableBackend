using APEC.ProyectoFinal.API.Dal;

namespace APEC.ProyectoFinal.API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            TipoMoneda = new TipoMonedaRepository(databaseContext);
            TipoCuentaContable = new TipoCuentaContableRepository(databaseContext);
            EntradaCuentaContable = new EntradaContableRepository(databaseContext);
            SistemaAuxiliares = new SistemaAuxiliareRepository(databaseContext);
            CuentaContable = new CuentaContableRepository(databaseContext);
        }

        public ITipoMonedaRepository TipoMoneda { get; }

        public ITipoCuentaContableRepository TipoCuentaContable { get; }

        public IEntradaContableRepository EntradaCuentaContable { get; }

        public ISistemaAuxiliareRepository SistemaAuxiliares { get; }

        public ICuentaContableRepository CuentaContable { get; }

        public async Task CompleteAsync() => await _databaseContext.SaveChangesAsync();
    }
}