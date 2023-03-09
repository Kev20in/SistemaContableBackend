using APEC.ProyectoFinal.API.Dal;
using APEC.ProyectoFinal.API.Entities;

namespace APEC.ProyectoFinal.API.Repository
{
    public class TipoMonedaRepository : BaseRepository<TipoMoneda, DatabaseContext>, ITipoMonedaRepository
    {
        public TipoMonedaRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}