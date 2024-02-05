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
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.Property(p => p.Nombre)
                .HasMaxLength(100);
            builder.Property(p => p.Observacion)
                .HasMaxLength(100);
            var lista = new List<Categoria>
            {
                new () { Id =1,Nombre ="Parrilla",Observacion=""},
                new () { Id =2,Nombre ="Hamburguesa",Observacion=""},
                new () { Id =3,Nombre ="Gaseosa",Observacion=""},
                new () { Id =4,Nombre ="Cerveza",Observacion=""},
                new () { Id =5,Nombre ="Wisky",Observacion=""},
                new () { Id =6,Nombre ="Pisco",Observacion=""}
            };
            builder.HasData(lista);
        }
    }
}
