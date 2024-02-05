using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.DataAcces.Configurations
{
    public class DetalleMovimientoConfiguration : IEntityTypeConfiguration<DetalleMovimiento>
    {
        public void Configure(EntityTypeBuilder<DetalleMovimiento> builder)
        {
            builder.Property(p => p.Cantidad);
            builder.Property(p => p.PrecioUnitario);
            builder.Property(p => p.Total);
            builder.Property(p => p.Observacion)
                .HasMaxLength(150);


        }
    }
}
