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
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.Property(p => p.Nombre)
                .HasMaxLength(100);
            builder.Property(p=>p.Observacion)
                .HasMaxLength(100);
            var lista = new List<Marca>
            {
                new() {Id = 1,Nombre="Inka Kola", Observacion=""},
                new() {Id = 2, Nombre="Coca Cola", Observacion=""},
                new() {Id = 3, Nombre="Queirolo", Observacion=""},
                new() {Id = 4, Nombre="Tabernero", Observacion=""},
                new() {Id = 5, Nombre="Pilsen", Observacion=""}
            };
            builder.HasData(lista);
        }
    }
}
