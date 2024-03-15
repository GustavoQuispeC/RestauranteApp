using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Entities
{
    public class Dashboard
    {
        public float TotalMovimiento { get; set; }
        public int CantidadMovimientos { get; set; }
        public int CantidadClientes { get; set; }
        public int CantidadProductos { get; set; }
    }
}
