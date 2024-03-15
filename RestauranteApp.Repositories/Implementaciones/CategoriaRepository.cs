using RestauranteApp.DataAcces.Data;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;



namespace RestauranteApp.Repositories.Implementaciones
{
    public class CategoriaRepository : RepositoryBase<Categoria>,ICategoriaRepository
    {
        public CategoriaRepository(RestauranteAppDbContext context) : base(context)
        {
        }
    }
}
