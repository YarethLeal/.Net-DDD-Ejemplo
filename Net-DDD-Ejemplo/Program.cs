using Dominio.Interfaces;
using Infraestructura;
using Net_DDD_Ejemplo.Queries;
using Net_DDD_Ejemplo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<DatabaseContext>(options =>
//{
//    options.UseS
//});
builder.Services.AddScoped<IEstudianteRepository, EstudianteRepositorio>();
builder.Services.AddScoped<EstudianteQueries>();
builder.Services.AddScoped<EstudianteService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
