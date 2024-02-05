using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.DataAcces.Data
{
    public class RestauranteAppDbContext: DbContext
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
    }
}
