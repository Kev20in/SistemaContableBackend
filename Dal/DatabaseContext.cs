using APEC.ProyectoFinal.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace APEC.ProyectoFinal.API.Dal
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbContext Context => this;

        public DbSet<CuentaContable> CuentaContables { get; }

        public DbSet<TipoCuentaContable> TipoCuentaContables { get; }

        public DbSet<TipoMoneda> TipoMonedas { get; }

        public DbSet<EntradaContable> EntradaContables { get; }

        public DbSet<SistemaAuxiliares> SistemaAuxiliares { get; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        Task<int> IDatabaseContext.SaveChangesAsync() => SaveChangesAsync();
    }
}