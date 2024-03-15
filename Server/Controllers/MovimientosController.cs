using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Shared.Response;
using RestauranteApp.Shared;
using System.Security.Claims;
using RestauranteApp.Shared.Request;
using RestauranteApp.Entities;
using AutoMapper;

namespace RestauranteApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {


        private readonly IMovimientoRepository _repository;
        private readonly ILogger<MovimientosController> _logger;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public MovimientosController(IMovimientoRepository repository, ILogger<MovimientosController> logger, IClienteRepository clienteRepository, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [Authorize(Roles = Constantes.RolCliente)]
        public async Task<IActionResult> Post(MovimientoDto request)
        {
            var response = new BaseResponse();
            try
            {
                // Buscamos el ID del cliente basado en el correo electrónico
                var email = HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;
                var cliente = await _clienteRepository.BuscarPorEmailAsync(email);

                if (cliente is null)
                {
                    response.MensajeError = $"El cliente con el correo {email} no existe!";
                    return BadRequest(response);
                }

                request.ClienteId = cliente.Id;

                //transforma la clase movimientoDto a movimiento
                var movimiento = _mapper.Map<Movimiento>(request);

                await _repository.CrearTransaccionAsync();
                await _repository.AddAsync(movimiento);

                await _repository.ConfirmarTransaccionAsync();

                _logger.LogInformation("Se creo la venta de forma correcta");

                response.Exito = true;

                return Ok(response);
            }
            catch (Exception ex)
            {
                response.MensajeError = "Error al crear la venta";
                await _repository.ResetearTransaccionAsync();
                _logger.LogCritical(ex, "{MensajeError} {Message}", response.MensajeError, ex.Message);
                return BadRequest(response);
            }
        }

    }
}
