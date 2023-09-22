using System.Text.Json.Serialization;
using APICatalogo.Context;
using APICatalogo.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
                options =>options.UseSqlServer
                               (
                                    builder.
                                    Configuration.
                                    GetConnectionString("ConexaoPadrao")
                                )
                            );


// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(
    options=>options.JsonSerializerOptions
                    .ReferenceHandler = ReferenceHandler.IgnoreCycles
    );

builder.Services.AddTransient<IMeuServico,MeuServico>();
                    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
