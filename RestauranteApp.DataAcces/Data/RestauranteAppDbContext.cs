using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestauranteApp.DataAccess;
using System;
using System.Collections.Generic;


namespace RestauranteApp.DataAcces.Data
{
    public class RestauranteAppDbContext: IdentityDbContext<IdentityUserRestauranteApp>
    {
        public RestauranteAppDbContext(DbContextOptions<RestauranteAppDbContext>options) 
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RestauranteAppDbContext).Assembly);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<string>()
                .HaveMaxLength(100);
        }
    }
}
