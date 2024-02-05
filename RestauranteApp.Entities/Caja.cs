using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Entities
{
    public class Caja : EntityBase
    {
        public float SaldoInicial { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public float TotalRecaudado { get; set; }
        public string? Observaciones { get; set; }

    }
}
