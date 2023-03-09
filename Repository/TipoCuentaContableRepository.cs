using APEC.ProyectoFinal.API.Dal;
using APEC.ProyectoFinal.API.Entities;

namespace APEC.ProyectoFinal.API.Repository
{
    public class TipoCuentaContableRepository : BaseRepository<TipoCuentaContable, DatabaseContext>, ITipoCuentaContableRepository
    {
        public TipoCuentaContableRepository(DatabaseContext context) : base(context)
        {
        }
    }
}