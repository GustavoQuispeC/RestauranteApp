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
    public class MovimientoConfiguration : IEntityTypeConfiguration<Movimiento>
    {
        public void Configure(EntityTypeBuilder<Movimiento> builder)
        {
            builder.Property(p => p.Total);
            builder.Property(p => p.Descuento);
            builder.Property(p => p.MontoFinal);
            builder.Property(p => p.PagoRecibido);
            builder.Property(p => p.PagoVuelto);
            builder.Property(p => p.Observacion)
                .HasMaxLength(100);


        }
    }
}
