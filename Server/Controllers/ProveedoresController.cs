using Microsoft.AspNetCore.Mvc;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Shared;
using System.ComponentModel.DataAnnotations;

namespace RestauranteApp.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProveedoresController : ControllerBase
    {
        private readonly IProveedorRepository _repository;

        public ProveedoresController(IProveedorRepository repository) 
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult>Get()
        {
            return Ok(await _repository.ListAsync());
        }


        [HttpPost]
        public async Task<IActionResult>Post(ProveedorDto request)
        {
            var proveedor = new Proveedor
            {
                RazonSocial = request.RazonSocial,
                Nombres = request.Nombres,
                Apellidos = request.Apellidos,
                Telefono = request.Telefono,
                Email = request.Email,
                Observacion = request.Observacion,
            };
            await _repository.AddAsync(proveedor);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult>Get(int id)
        {
            var proveedor =await _repository.FindAsync(id);
            if(proveedor ==null)
            {
                return NotFound();
            }
            return Ok(proveedor);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult>Put(int id, ProveedorDto request)
        {
            var proveedor = await _repository.FindAsync(id);
            if(proveedor ==null)
            {
                return NotFound();
            }
            proveedor.RazonSocial = request.RazonSocial;
            proveedor.Nombres = request.Nombres;
            proveedor.Apellidos = request.Apellidos;
            proveedor.Telefono = request.Telefono;
            proveedor.Email = request.Email;
            proveedor.Observacion = request.Observacion;
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
