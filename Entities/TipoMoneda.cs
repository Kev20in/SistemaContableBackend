namespace APEC.ProyectoFinal.API.Entities
{
    public class TipoMoneda : IEntity
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public double UltimaTasaCambiara { get; set; }

        public bool Estado { get; set; }
    }
}