using RestauranteApp.Entities;
using RestauranteApp.Entities.Infos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteApp.Repositories.Interfaces
{
    public interface IProductoRepository:IRepositoryBase<Producto>
    {
        Task<ICollection<ProductoInfo>> ListarAsync(string? filtro);
    }
}
