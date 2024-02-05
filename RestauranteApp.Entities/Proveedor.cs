using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Entities
{
    public class Proveedor : EntityBase
    {
        public string? RazonSocial { get; set; }
        public string Nombres { get; set; } = default!;
        public string Apellidos { get; set; } = default!;
        public string Telefono { get; set; } = default!;
        public string? email { get; set; }
        public string? Observacion { get; set; }
    }
}
