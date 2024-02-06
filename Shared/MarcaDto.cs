using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Shared
{
    public class MarcaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = default!;
        public string? Observacion { get; set; }
    }
}
