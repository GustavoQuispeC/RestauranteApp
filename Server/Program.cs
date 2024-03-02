using ECommerceWeb.DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RestauranteApp.DataAcces.Data;
using RestauranteApp.DataAccess;
using RestauranteApp.Repositories.Implementaciones;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Server.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();

builder.Services.AddControllers();
builder.Services.AddTransient<IProveedorRepository, ProveedorRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<IMarcaRepository, MarcaRepository>();
builder.Services.AddTransient<ITipoPagoRepository, TipoPagoRepository>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IUnidadMedidaRepository, UnidadMedidaRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

builder.Services.AddTransient<IUserService, UserService>();



builder.Services.AddDbContext<RestauranteAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestauranteAppDb"));
});

// Configuramos ASP.NET Identity Core - politicas
builder.Services.AddIdentity<IdentityUserRestauranteApp, IdentityRole>(policies =>
{
    policies.Password.RequireDigit = false;
    policies.Password.RequireLowercase = true;
    policies.Password.RequireUppercase = true;
    policies.Password.RequireNonAlphanumeric = false;
    policies.Password.RequiredLength = 8;

    policies.User.RequireUniqueEmail = true; //Valida correo electronico
})
    .AddEntityFrameworkStores<RestauranteAppDbContext>()
    .AddDefaultTokenProviders(); //token proveido por identity

//configuramos el contexto de la seguridad del API
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    var secretKey = Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"] ??
        throw new InvalidOperationException("No se configuro el secretKey"));
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(secretKey)
    };
});





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
//Authentication y autorizacion
app.UseAuthentication();
app.UseAuthorization();

//app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

//creacion de variabler scope
using (var scope = app.Services.CreateScope())
{
    await UserDataSeeder.Seed(scope.ServiceProvider);
}

app.Run();
