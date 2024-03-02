
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using RestauranteApp.DataAcces.Data;


namespace RestauranteApp.Repositories.Implementaciones
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(RestauranteAppDbContext context) 
            : base(context)
        {
        }

        public async Task<Cliente?> BuscarPorEmailAsync(string email)
        {
            return await Context.Set<Cliente>().FirstOrDefaultAsync(o => o.Email.Equals(email));
        }
    }
}
