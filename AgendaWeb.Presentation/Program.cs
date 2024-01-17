using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurando o projeto para MVC
builder.Services.AddControllersWithViews();

//capturar a connectionstring mapeada no 'appsettings.json'
var connectionString = builder.Configuration.GetConnectionString("AgendaWeb2");

//injeção de dependencia para as classes do repositorio
builder.Services.AddTransient<IEventoRepository>
    (map => new EventoRepository(connectionString));

builder.Services.AddTransient<IUsuarioRepository>(map => new UsuarioRepository(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
