using APEC.ProyectoFinal.API.Dal;
using APEC.ProyectoFinal.API.Entities;

namespace APEC.ProyectoFinal.API.Repository
{
    public class EntradaContableRepository : BaseRepository<EntradaContable, DatabaseContext>, IEntradaContableRepository
    {
        public EntradaContableRepository(DatabaseContext context) : base(context)
        {
        }
    }
}