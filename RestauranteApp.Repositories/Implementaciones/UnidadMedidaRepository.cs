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
    public class UnidadMedidaRepository : RepositoryBase<UnidadMedida>, IUnidadMedidaRepository
    {
        public UnidadMedidaRepository(RestauranteAppDbContext context) : base(context)
        {
        }
    }
}
