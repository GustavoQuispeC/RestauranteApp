
using Microsoft.AspNetCore.Mvc;
using RestauranteApp.Server.Services;
using RestauranteApp.Shared.Request;


namespace RestauranteApp.Server.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUserService _service;

        public UsuariosController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDtoRequest request)
        {
            var response = await _service.LoginAsync(request);

            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegistrarUsuarioDto request)
        {
            var response = await _service.RegisterAsync(request);

            return Ok(response);
        }
    }
}