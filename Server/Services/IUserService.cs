
using RestauranteApp.Shared.Request;
using RestauranteApp.Shared.Response;

namespace RestauranteApp.Server.Services
{
    public interface IUserService
    {
        Task<LoginDtoResponse> LoginAsync(LoginDtoRequest request);
        Task<BaseResponse> RegisterAsync(RegistrarUsuarioDto request);
    }
}
