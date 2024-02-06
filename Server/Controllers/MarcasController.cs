using Microsoft.AspNetCore.Mvc;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Shared;

namespace RestauranteApp.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MarcasController : ControllerBase
    {
        private readonly IMarcaRepository _repository;

        public MarcasController(IMarcaRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post(MarcaDto request)
        {
            var marca = new Marca
            {
                Nombre = request.Nombre,
                Observacion = request.Observacion
            };
            await _repository.AddAsync(marca);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var marca = await _repository.FindAsync(id);
            if (marca == null)
            {
                return NotFound();
            }
            return Ok(marca);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, MarcaDto request)
        {
            var marca = await _repository.FindAsync(id);
            if (marca == null)
            {
                return NotFound();
            }
            marca.Nombre = request.Nombre;
            marca.Observacion = request.Observacion;
            await _repository.UpdateAsync();
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}
