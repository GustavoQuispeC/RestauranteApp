using AutoMapper;
using RestauranteApp.Entities;
using RestauranteApp.Shared.Request;

namespace RestauranteApp.Server.PerfilesAutomapper
{
    public class MovimientoProfile : Profile
    {
        //Mapeo de MovimientoDto a Movimiento
        //Mapeo de DetalleMovimientoDto a DetalleMovimiento
        public MovimientoProfile()
        {
            CreateMap<MovimientoDto, Movimiento>();
            CreateMap<DetalleMovimientoDto, DetalleMovimiento>();
        }
    }
}
