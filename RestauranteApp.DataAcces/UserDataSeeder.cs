using RestauranteApp.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RestauranteApp.DataAccess;

namespace ECommerceWeb.DataAccess;

public static class UserDataSeeder
{
    public static async Task Seed(IServiceProvider service)
    {
        // UserManager (Repositorio de Usuarios)
        var userManager = service.GetRequiredService<UserManager<IdentityUserRestauranteApp>>();

        // RoleManager (Repositorio de Roles)
        var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

        // Crear los roles
        var adminRole = new IdentityRole(Constantes.RolAdministrador);

        var clienteRole = new IdentityRole(Constantes.RolCliente);

        if (!await roleManager.RoleExistsAsync(Constantes.RolAdministrador))
        {
            await roleManager.CreateAsync(adminRole);
        }
        
        if (!await roleManager.RoleExistsAsync(Constantes.RolCliente))
        {
            await roleManager.CreateAsync(clienteRole);
        }

        // Creamos el usuario Administrador
        var adminUser = new IdentityUserRestauranteApp
        {
            NombreCompleto = "Administrador del Sistema",
            FechaNacimiento = DateTime.Parse("1990-01-01"),
            Direccion = "Av. Siempre viva 123",
            UserName = "admin",
            Email = "admin@gmail.com",
            EmailConfirmed = true
        };

        //creando usuario
        var result = await userManager.CreateAsync(adminUser, "pa$$W0rD@123");
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(adminUser, Constantes.RolAdministrador);
        }
    }
}