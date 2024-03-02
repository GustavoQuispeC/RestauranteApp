using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace RestauranteApp.DataAccess;

public class IdentityUserRestauranteApp : IdentityUser
{ //especificamos los campos y tipos de columnas antes de la migracion 

    [StringLength(200)]
    public string NombreCompleto { get; set; } = default!;

    [Column(TypeName = "DATE")]
    public DateTime FechaNacimiento { get; set; }

    [StringLength(250)]
    public string? Direccion { get; set; }
}