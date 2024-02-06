using Microsoft.AspNetCore.Mvc;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Shared;

namespace RestauranteApp.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TipoPagosController : ControllerBase
    {
        private readonly ITipoPagoRepository _repository;

        public TipoPagosController(ITipoPagoRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post(TipoPagoDto request)
        {
            var tipoPago = new TipoPago
            {
                Nombre = request.Nombre,
                Observacion = request.Observacion
            };
            await _repository.AddAsync(tipoPago);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var tipoPago = await _repository.FindAsync(id);
            if (tipoPago == null)
            {
                return NotFound();
            }
            return Ok(tipoPago);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, TipoPagoDto request)
        {
            var tipoPago = await _repository.FindAsync(id);
            if (tipoPago == null)
            {
                return NotFound();
            }
            tipoPago.Nombre = request.Nombre;
            tipoPago.Observacion = request.Observacion;
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
