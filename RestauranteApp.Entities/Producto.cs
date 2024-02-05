using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Entities
{
    public class Producto : EntityBase
    {
        public string Nombre { get; set; } = default!;
        public float PrecioVenta { get; set; }
        public float PrecioCompra { get; set; }
        public int Stock { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? UrlImagen { get; set; }
        public string? Observacion { get; set; }

        public Categoria Categoria { get; set; } = default!;
        public int CategoriaId { get; set; }

        public Marca Marca { get; set; } = default!;
        public int MarcaId { get; set; }

        public Proveedor Proveedor { get; set; } = default!;
        public int ProveedorId { get; set; }

        public UnidadMedida UnidadMedida { get; set; } = default!;
        public int UnidadMedidaId { get; set; }
    }
}
