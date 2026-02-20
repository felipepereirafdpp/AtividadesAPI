using Microsoft.EntityFrameworkCore;
using AtividadesAPI.ApiDocs.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DocumentosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RGContext") ?? throw new InvalidOperationException("Connection string 'RGContext' not found.")));

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseCors(politica => politica
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
