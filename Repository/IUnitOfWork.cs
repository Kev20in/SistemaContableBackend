namespace APEC.ProyectoFinal.API.Repository
{
    public interface IUnitOfWork
    {
        ICuentaContableRepository CuentaContable { get; }

        IEntradaContableRepository EntradaCuentaContable { get; }

        ISistemaAuxiliareRepository SistemaAuxiliares { get; }

        ITipoCuentaContableRepository TipoCuentaContable { get; }

        ITipoMonedaRepository TipoMoneda { get; }

        Task CompleteAsync();
    }
}