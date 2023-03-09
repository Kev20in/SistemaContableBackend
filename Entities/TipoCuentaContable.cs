namespace APEC.ProyectoFinal.API.Entities
{
    public class TipoCuentaContable : IEntity
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public string Origen { get; set; }

        public bool Estado { get; set; }
    }
}