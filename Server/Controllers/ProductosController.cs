using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestauranteApp.DataAcces.Data;
using RestauranteApp.Entities;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Server.Services;
using RestauranteApp.Shared.Request;

namespace RestauranteApp.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepository _repository;
        public IFileUpload _fileUpload;
        

        public ProductosController(IProductoRepository repository, IFileUpload fileUpload)
        {
            _repository = repository;
            _fileUpload = fileUpload;
            
        }


        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await _repository.ListarAsync());
        //}

        //Get: api/productos
        //Get: api/productos?filtro=string

        [HttpGet]
        public async Task<IActionResult> Get(string? filtro)
        {
            return Ok(await _repository.ListarAsync(filtro));
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
                UnidadMedidaId = producto.UnidadMedidaId,
                UrlImagen = producto.UrlImagen
            };
            return Ok(response);
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
            

            if (request.FileName != null)
                producto.UrlImagen = await _fileUpload.UploadFileAsync(request.Base64Imagen, request.FileName);
          
            await _repository.AddAsync(producto);

            return Ok();
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

            if (!string.IsNullOrWhiteSpace(request.Base64Imagen))
            {
                producto.UrlImagen = await _fileUpload.UploadFileAsync(request.Base64Imagen, request.FileName);
            }

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

