namespace RestauranteApp.Entities;

public class Cliente : EntityBase
{
    public string Nombres { get; set; } = default!;
    public string Apellidos { get; set; } = default!;
    public string Email { get; set; } = default!;
    public DateTime FechaNacimiento { get; set; }
    
    
}