using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Shared
{
    public class ProveedorDto
    {
        public int Id { get; set; }
        public string? RazonSocial { get; set; }
        public string Nombres { get; set; } = default!;
        public string Apellidos { get; set; } = default!;
        public string Telefono { get; set; } = default!;
        public string? Email { get; set; }
        public string? Observacion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
