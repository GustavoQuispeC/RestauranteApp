using RestauranteApp.DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RestauranteApp.DataAcces.Data;
using RestauranteApp.Repositories.Implementaciones;
using RestauranteApp.Repositories.Interfaces;
using RestauranteApp.Server.Services;
using System.Text;
using RestauranteApp.Server.PerfilesAutomapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<IProveedorRepository, ProveedorRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<IMarcaRepository, MarcaRepository>();
builder.Services.AddTransient<ITipoPagoRepository, TipoPagoRepository>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IUnidadMedidaRepository, UnidadMedidaRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IMovimientoRepository, MovimientoRepository>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IFileUpload, FileUpload>();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MovimientoProfile>();
});

builder.Services.AddDbContext<RestauranteAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestauranteAppDb"));
});

// Configuracion de las politicas de  ASP.NET Identity Core
builder.Services.AddIdentity<IdentityUserRestauranteApp, IdentityRole>(politicas =>
{
    politicas.Password.RequireDigit = false;
    politicas.Password.RequireLowercase = true;
    politicas.Password.RequireUppercase = true;
    politicas.Password.RequireNonAlphanumeric = false;
    politicas.Password.RequiredLength = 8;
    politicas.User.RequireUniqueEmail = true; //Valida correo electronico
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

// Configuracion de HTTP request pipeline.
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

app.MapControllers();
app.MapFallbackToFile("index.html");

//creacion de variabler scope
using (var scope = app.Services.CreateScope())
{
    await UserDataSeeder.Seed(scope.ServiceProvider);
}
app.Run();
