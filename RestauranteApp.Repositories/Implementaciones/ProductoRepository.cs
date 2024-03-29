﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RestauranteApp.DataAcces.Data;
using RestauranteApp.Entities;
using RestauranteApp.Entities.Informacion;
using RestauranteApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Repositories.Implementaciones
{
    public class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
    {
        public ProductoRepository(RestauranteAppDbContext context) : base(context)
        {
        }

        public async Task<ICollection<ProductoInfo>> ListarAsync(string? filtro)
        {
            var productos = Context.Set<Producto>()
                .Where(p => p.Estado)
                .AsQueryable();
            if (filtro != null)
            {
                productos = productos.Where(p => p.Nombre.Contains(filtro));
            }

            return await productos
                .Select(x => new ProductoInfo
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    PrecioVenta = x.PrecioVenta,
                    PrecioCompra = x.PrecioCompra,
                    Stock = x.Stock,
                    FechaVencimiento = x.FechaVencimiento,
                    Observacion = x.Observacion,
                    Categoria = x.Categoria.Nombre,
                    CategoriaId = x.CategoriaId,
                    ProveedorId = x.ProveedorId,
                    MarcaId = x.MarcaId,
                    Marca = x.Marca.Nombre,
                    Proveedor = x.Proveedor.RazonSocial,
                    UnidadMedida = x.UnidadMedida.Nombre,
                    UrlImagen = x.UrlImagen
                })
                .AsNoTracking()
                .ToListAsync();
                
               
        }

       
    }
}
