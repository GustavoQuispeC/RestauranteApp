
namespace RestauranteApp.Shared.Request
{
    public class DetalleMovimientoDto
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public float Total { get; set; }
    }
}
