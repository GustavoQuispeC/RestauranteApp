using RestauranteApp.Entities;

namespace RestauranteApp.Repositories.Interfaces
{
    public interface IMovimientoRepository : IRepositoryBase<Movimiento>
    {
        Task CrearTransaccionAsync();
        Task ConfirmarTransaccionAsync();

        Task ResetearTransaccionAsync();

        Task<Dashboard> MostrarDashboard();
    }
}
