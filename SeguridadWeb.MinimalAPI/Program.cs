
using SeguridadWeb.EntidadesDeNegocio;
using SeguridadWeb.LogicaDeNegocio;
using SeguridadWeb.MinimalAPI.EndPoints;
using SeguridadWeb.MinimalAPI.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<RolBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapGet("/Cliente", () => {
    var list = new List<Cliente>();
    list.Add(new Cliente { Id = 1, Nombre = "Marvin" });
    return list;
});
app.MapPost("/cliente", (Cliente pCliente) => {
pCliente.ejecutarxCosa((int pNum) => { },12);
    
    return pCliente.Id;
});

app.MapGet("/test", async () =>{
    RolBL rolBL = new RolBL();
    return await rolBL.ObtenerTodosAsync();
});
app.MapPost("/test/{id}", async (Rol pRol,int id) => {
    RolBL rolBL = new RolBL();
    pRol.Id = id;
    int result =await rolBL.ModificarAsync(pRol);
    return result;
});
app.AddEndPoints();

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
