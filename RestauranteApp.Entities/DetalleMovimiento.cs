using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Entities
{
    public class DetalleMovimiento:EntityBase
    {
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public float Total { get; set; }
        public string? Observacion { get; set; }

        public Producto Producto { get; set; } = default!;
        public int ProductoId { get; set; }

        public Movimiento Movimiento { get; set; } = default!;
        public int MovimientoId { get; set; }
    }
}
