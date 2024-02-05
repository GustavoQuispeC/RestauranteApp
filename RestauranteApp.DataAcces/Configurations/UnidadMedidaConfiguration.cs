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
    public class UnidadMedidaConfiguration : IEntityTypeConfiguration<UnidadMedida>
    {
        public void Configure(EntityTypeBuilder<UnidadMedida> builder)
        {
            builder.Property(p => p.Nombre)
                .HasMaxLength(100);
            var lista = new List<UnidadMedida>
            {
                new() { Id = 1,Nombre="Unidad" },
                new() { Id = 2,Nombre="Litro" },
                new() { Id = 3,Nombre="Caja"},
                new() { Id = 4,Nombre="Paquete"}
            };
            builder.HasData(lista);
               
        }
    }
}
