using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Entities
{
    public class Marca : EntityBase
    {
        public string Nombre { get; set; } = default!;
        public string? Observacion { get; set; }
    }
}
