using APEC.ProyectoFinal.API.Dal;
using APEC.ProyectoFinal.API.Entities;

namespace APEC.ProyectoFinal.API.Repository
{
    public class CuentaContableRepository : BaseRepository<CuentaContable, DatabaseContext>, ICuentaContableRepository
    {
        public CuentaContableRepository(DatabaseContext context) : base(context)
        {
        }
    }
}