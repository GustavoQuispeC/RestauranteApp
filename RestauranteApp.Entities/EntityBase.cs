using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public bool Estado { get; set; }
        protected EntityBase()
        {
            Estado = true;
        }
    }
}
