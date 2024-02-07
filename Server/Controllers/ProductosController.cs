using Microsoft.AspNetCore.Mvc;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Shared;
using RestauranteApp.Shared.Request;

namespace RestauranteApp.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepository _repository;

        public ProductosController(IProductoRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.ListarAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductoDtoRequest request)
        {
            var producto = new Producto
            {
                Nombre = request.Nombre,
                PrecioVenta = request.PrecioVenta,
                PrecioCompra = request.PrecioCompra,
                Stock = request.Stock,
                FechaVencimiento = request.FechaVencimiento,
                Observacion = request.Observacion,
                CategoriaId = request.CategoriaId,
                MarcaId = request.MarcaId,
                ProveedorId = request.ProveedorId,
                UnidadMedidaId = request.UnidadMedidaId
            };
            await _repository.AddAsync(producto);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var producto = await _repository.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            var response = new ProductoDtoRequest
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                PrecioVenta = producto.PrecioVenta,
                PrecioCompra = producto.PrecioCompra,
                Stock = producto.Stock,
                FechaVencimiento = producto.FechaVencimiento,
                Observacion = producto.Observacion,
                CategoriaId = producto.CategoriaId,
                MarcaId = producto.MarcaId,
                ProveedorId = producto.ProveedorId,
                UnidadMedidaId = producto.UnidadMedidaId
            };
            return Ok(response);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, ProductoDtoRequest request)
        {
            var producto = await _repository.FindAsync(id);
            if(producto is null)
            {
                return NotFound();
            }
            producto.Nombre = request.Nombre;
            producto.PrecioVenta= request.PrecioVenta;
            producto.PrecioCompra = request.PrecioCompra;
            producto.Stock = request.Stock;
            producto.FechaVencimiento= request.FechaVencimiento;
            producto.Observacion = request.Observacion;
            producto.CategoriaId = request.CategoriaId;
            producto.MarcaId = request.MarcaId;
            producto.ProveedorId = request.ProveedorId;
            producto.UnidadMedidaId = request.UnidadMedidaId;

            await _repository.UpdateAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult>Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
    
}

