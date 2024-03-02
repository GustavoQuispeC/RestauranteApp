
using System.ComponentModel.DataAnnotations;

namespace RestauranteApp.Shared.Request;

public class RegistrarUsuarioDto
{
    [Required(ErrorMessage = Constantes.CamposRequerido)]
    [Display(Name = "Nombre Completo")]
    public string NombreCompleto { get; set; } = default!;

    public DateTime FechaNacimiento { get; set; } = DateTime.Today.AddYears(-20);

    [Required(ErrorMessage = Constantes.CamposRequerido)] 
    public string Direccion { get; set; } = default!;

    [Required(ErrorMessage = Constantes.CamposRequerido)]
    [Display(Name = "Nombre de Usuario")]
    public string NombreUsuario { get; set; } =default!;
    
    [EmailAddress]
    public string Email { get; set; } = default!;

    [Required(ErrorMessage = Constantes.CamposRequerido)]
    public string Password { get; set; } = default!;

    [Compare(nameof(Password), ErrorMessage = "Las claves no coinciden")]
    public string ConfirmPassword { get; set; } = default!;

}