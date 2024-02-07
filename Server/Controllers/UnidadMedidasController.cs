using Microsoft.AspNetCore.Mvc;
using RestauranteApp.Repositories.Interfaces;

namespace RestauranteApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnidadMedidasController : ControllerBase
    {
        private readonly IUnidadMedidaRepository _repository;

        public UnidadMedidasController(IUnidadMedidaRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListAsync());
        }

    }
}
