namespace APEC.ProyectoFinal.API.Entities
{
    public class SistemaAuxiliares : IEntity
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public bool Estado { get; set; }
    }
}