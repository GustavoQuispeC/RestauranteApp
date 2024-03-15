using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.DataAcces.Configuraciones
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(p => p.Nombre)
                .HasMaxLength(100);
            builder.Property(p => p.PrecioVenta);
            builder.Property(p => p.PrecioCompra);
            builder.Property(p => p.Stock);
            builder.Property(p => p.FechaVencimiento)
                .HasColumnType("DATE");
            builder.Property(p => p.UrlImagen);
            builder.Property(p => p.Observacion)
                .HasMaxLength(150);

        }
    }
}
