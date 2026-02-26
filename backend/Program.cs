using backend.Services;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Registrar serviços
builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddScoped<SwapiService>();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();