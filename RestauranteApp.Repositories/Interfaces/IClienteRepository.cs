using RestauranteApp.Entities;

namespace RestauranteApp.Repositories.Interfaces
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {

        Task<Cliente?> BuscarPorEmailAsync(string email);

    }
}
