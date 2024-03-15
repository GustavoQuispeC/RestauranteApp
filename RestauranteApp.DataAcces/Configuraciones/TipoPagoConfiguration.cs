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
    public class TipoPagoConfiguration : IEntityTypeConfiguration<TipoPago>
    {
        public void Configure(EntityTypeBuilder<TipoPago> builder)
        {
            builder.Property(p => p.Nombre)
                .HasMaxLength(100);
            builder.Property(p => p.Observacion)
                .HasMaxLength(150);
            var lista = new List<TipoPago>
            {
                new() {Id = 1,Nombre="Efectivo",Observacion="" },
                new() {Id = 2,Nombre="Transferencia",Observacion="" },
                new() {Id = 3,Nombre="Yape",Observacion="" },
                new() {Id = 4,Nombre="Plin",Observacion="" },
            };
            builder.HasData(lista);
        }
    }
}
