using UZUSIS.API.Configuration;
using UZUSIS.Application.Configuration;
using UZUSIS.Infra.Data.Context;
using UZUSIS.Infra.Data.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwagger();
builder.Services.AddDbContext<UZUSISContext>();


builder.Services.AddDependencyInjection();
builder.Services.ConfigureMappings();
builder.Services.AuthConfiguration();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

