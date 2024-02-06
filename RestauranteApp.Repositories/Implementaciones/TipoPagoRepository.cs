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
    public class TipoPagoRepository : RepositoryBase<TipoPago>, ITipoPagoRepository
    {
        public TipoPagoRepository(RestauranteAppDbContext context) : base(context)
        {
        }
    }
}
