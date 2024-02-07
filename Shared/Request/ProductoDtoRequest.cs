using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Shared.Request
{
    public class ProductoDtoRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = default!;
        public float PrecioVenta { get; set; }
        public float PrecioCompra { get; set; }
        public int Stock { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Observacion { get; set; }

        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int ProveedorId { get; set; }
        public int UnidadMedidaId { get; set; }
    }
}
