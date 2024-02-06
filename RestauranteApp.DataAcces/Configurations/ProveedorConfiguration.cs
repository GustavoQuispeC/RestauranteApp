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
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.Property(p=>p.RazonSocial)
                .HasMaxLength(100);
            builder.Property(p=>p.Nombres)
                .HasMaxLength(100);
            builder.Property(p=>p.Apellidos)
                .HasMaxLength(100);
            builder.Property(p=>p.Telefono)
                .HasMaxLength(20);
            builder.Property(p=>p.Email)
                .IsUnicode(false);
            builder.Property(p=>p.Observacion)
                .HasMaxLength(150);
        }
    }
}
