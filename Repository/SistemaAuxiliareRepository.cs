using APEC.ProyectoFinal.API.Dal;
using APEC.ProyectoFinal.API.Entities;

namespace APEC.ProyectoFinal.API.Repository
{
    public class SistemaAuxiliareRepository : BaseRepository<SistemaAuxiliares, DatabaseContext>, ISistemaAuxiliareRepository
    {
        public SistemaAuxiliareRepository(DatabaseContext context) : base(context)
        {
        }
    }
}