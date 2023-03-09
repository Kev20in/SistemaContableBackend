namespace APEC.ProyectoFinal.API.Dal
{
    public interface IDatabaseContext
    {
        Task<int> SaveChangesAsync();
    }
}