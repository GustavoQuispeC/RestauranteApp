using RestauranteApp.DataAcces.Data;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;


namespace RestauranteApp.Repositories.Implementaciones
{
    public class MovimientoRepository : RepositoryBase<Movimiento>, IMovimientoRepository
    {
        public MovimientoRepository(RestauranteAppDbContext context)
            : base(context)
        {
        }

        //guarda los datos de la venta en memoria
        public override async Task AddAsync(Movimiento entity)
        {
            await Context.AddAsync(entity);
        }

        //confirma la transaccion y guarda los datos en la base de datos
        public async Task ConfirmarTransaccionAsync()
        {
            await Context.Database.CommitTransactionAsync();
            await Context.SaveChangesAsync();
        }

        public async Task CrearTransaccionAsync()
        {
            await Context.Database.BeginTransactionAsync();
        }

        public Task<Dashboard> MostrarDashboard()
        {
            throw new NotImplementedException();
        }

        public async Task ResetearTransaccionAsync()
        {
            await Context.Database.RollbackTransactionAsync();
        }
    }
}
