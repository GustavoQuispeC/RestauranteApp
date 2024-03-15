
namespace RestauranteApp.Shared.Request
{
    public class MovimientoDto
    {
        public int ClienteId { get; set; }
        public float Total { get; set; }
        public ICollection<DetalleMovimientoDto> DetalleMovimiento { get; set; } = new List<DetalleMovimientoDto>();
    }
}
