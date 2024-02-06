using RestauranteApp.DataAcces.Data;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Repositories.Implementaciones
{
    public class ProveedorRepository : RepositoryBase<Proveedor>, IProveedorRepository
    {
        public ProveedorRepository(RestauranteAppDbContext context) 
            : base(context)
        {
        }
    }
}
