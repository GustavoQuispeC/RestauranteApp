﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Shared.Response
{
    public class ProductoDtoResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = default!;
        public float PrecioVenta { get; set; }
        public float PrecioCompra { get; set; }
        public int Stock { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Observacion { get; set; }

        public string Categoria { get; set; } = default!;
        public int CategoriaId { get; set; }

        public string Marca { get; set; } = default!;
        public int MarcaId { get; set; }    

        public string Proveedor { get; set; } = default!;
        public int ProveedorId { get; set; }

        public string UnidadMedida { get; set; } = default!;
        public int UnidadMedidaId { get; set; }

        public string? UrlImagen { get; set; }

    }
}