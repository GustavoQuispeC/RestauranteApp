using RestauranteApp.Entities;
using RestauranteApp.Entities.Informacion;


namespace RestauranteApp.Repositories.Interfaces
{
    public interface IProductoRepository:IRepositoryBase<Producto>
    {
        Task<ICollection<ProductoInfo>> ListarAsync(string? filtro);
    }
}
