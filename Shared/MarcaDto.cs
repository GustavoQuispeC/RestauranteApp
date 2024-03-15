using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Shared
{
    public class MarcaDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = Constantes.CamposRequerido)]
        [MaxLength(100)]
        public string Nombre { get; set; } = default!;
        public string? Observacion { get; set; }
    }
}
