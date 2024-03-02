using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Shared;

namespace RestauranteApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;

        public CategoriasController(ICategoriaRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Post(CategoriaDto request)
        {
            var categoria = new Categoria
            {
                Nombre = request.Nombre,
                Observacion = request.Observacion
               
            };
            await _repository.AddAsync(categoria);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var categoria = await _repository.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return Ok(categoria);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, CategoriaDto request)
        {
            var categoria = await _repository.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }
            categoria.Nombre = request.Nombre;
            categoria.Observacion = request.Observacion;
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
