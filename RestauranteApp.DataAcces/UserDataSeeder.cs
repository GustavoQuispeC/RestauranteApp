using RestauranteApp.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RestauranteApp.DataAccess;

namespace RestauranteApp.DataAccess;

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

        var supervisorRole = new IdentityRole(Constantes.RolSupervisor);

        var clienteRole = new IdentityRole(Constantes.RolCliente);


        if (!await roleManager.RoleExistsAsync(Constantes.RolAdministrador))
        {
            await roleManager.CreateAsync(adminRole);
        }
        if (!await roleManager.RoleExistsAsync(Constantes.RolSupervisor))
        {
            await roleManager.CreateAsync(supervisorRole);
        }

        if (!await roleManager.RoleExistsAsync(Constantes.RolCliente))
        {
            await roleManager.CreateAsync(clienteRole);
        }

    
        var adminUser = new IdentityUserRestauranteApp
        {
            NombreCompleto = "Administrador",
            FechaNacimiento = DateTime.Parse("1990-01-01"),
            Direccion = "Av. Brasil 1234",
            UserName = "admin",
            Email = "admin@gmail.com",
            EmailConfirmed = true
        };

        var result = await userManager.CreateAsync(adminUser, "pa$$W0rD@123");
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(adminUser, Constantes.RolAdministrador);
        }

        var supervisorUser = new IdentityUserRestauranteApp
        {
            NombreCompleto = "Supervisor",
            FechaNacimiento = DateTime.Parse("1990-01-01"),
            Direccion = "Av. Peru 1234",
            UserName = "supervisor",
            Email = "supervisor@gmail.com",
            EmailConfirmed = true
        };

        var resultSupervisor = await userManager.CreateAsync(supervisorUser, "pa$$W0rD@123");
        if (resultSupervisor.Succeeded)
        {
            await userManager.AddToRoleAsync(supervisorUser, Constantes.RolSupervisor);
        }
    }
}