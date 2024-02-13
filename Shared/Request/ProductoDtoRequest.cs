using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Shared.Request
{
    public class ProductoDtoRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage =Constantes.CamposRequerido)]
        [MaxLength(100)]
        public string Nombre { get; set; } = default!;

        [Range(1, 9999, ErrorMessage =Constantes.ValidacionRango)]
        [Display(Name ="Precio Unitario")]
        public float PrecioVenta { get; set; }

        //[Range(1, 9999)]
        public float PrecioCompra { get; set; }
        //[Range(1, 9999)]
        public int Stock { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        
        //[MaxLength(200)]
        public string? Observacion { get; set; }

        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int ProveedorId { get; set; }
        public int UnidadMedidaId { get; set; }
    }
}
