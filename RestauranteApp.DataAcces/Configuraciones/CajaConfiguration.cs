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
    public class CajaConfiguration : IEntityTypeConfiguration<Caja>
    {
        public void Configure(EntityTypeBuilder<Caja> builder)
        {
            builder.Property(p => p.SaldoInicial);
            builder.Property(p => p.FechaApertura);
            builder.Property(p => p.FechaCierre);
            builder.Property(p => p.TotalRecaudado);
            builder.Property(p => p.Observaciones)
                .HasMaxLength(250);

        }
    }
}
