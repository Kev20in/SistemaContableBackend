using System.ComponentModel.DataAnnotations.Schema;

namespace APEC.ProyectoFinal.API.Entities
{
    public class EntradaContable : IEntity
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public int SistemaAuxiliaresId { get; set; }

        [ForeignKey(nameof(CuentaContable))]
        public int CuentaContableId { get; set; }

        public DateTime FechaAsiento { get; set; }

        public double MontoAsiento { get; set; }

        public bool Estado { get; set; }

        public SistemaAuxiliares SistemaAuxiliares { get; set; }

        public CuentaContable CuentaContable { get; set; }
    }
}