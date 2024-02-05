using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Entities
{
    public class Movimiento : EntityBase
    {
        public float Monto { get; set; }
        public float Descuento { get; set; }
        public float MontoFinal { get; set; }
        public float PagoRecibido { get; set; }
        public float PagoVuelto { get; set; }
        public string? Observacion { get; set; }

        public Caja Caja { get; set; } = default!;
        public int CajaId { get; set; }

        public TipoPago TipoPago { get; set; } = default!;
        public int TipoPagoId { get; set; }
    }
}
