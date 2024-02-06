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
    public class CategoriaRepository : RepositoryBase<Categoria>,ICategoriaRepository
    {
        public CategoriaRepository(RestauranteAppDbContext context) : base(context)
        {
        }
    }
}
