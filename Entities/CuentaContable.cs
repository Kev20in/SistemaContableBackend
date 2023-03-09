using System.ComponentModel.DataAnnotations.Schema;

namespace APEC.ProyectoFinal.API.Entities
{
    public class CuentaContable : IEntity
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public bool PermiteTransaciones { get; set; }

        public int Nivel { get; set; }

        public string CuentaMayor { get; set; }

        public double Balance { get; set; }

        public bool Estado { get; set; }

        [ForeignKey(nameof(TipoCuentaContable))]
        public int TipoCuentaContableId { get; set; }

        [ForeignKey(nameof(TipoMoneda))]
        public int TipoMonedaId { get; set; }

        public TipoCuentaContable TipoCuentaContable { get; set; }

        public TipoMoneda TipoMoneda { get; set; }
    }
}