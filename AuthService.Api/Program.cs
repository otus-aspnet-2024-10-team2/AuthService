using AuthService.Api;
using AuthService.Api.Mapping;
using AuthService.Application.Mapping;
using AuthService.Application.Services;
using AuthService.DataAccess;
using AuthService.DataAccess.Repository;
using AuthService.Domain.Abstractions;
using AutoMapper;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextWithConfigurations();

builder.Services.AddSingleton<IMapper>(
    new Mapper(
        new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<UserMappingsProfile>();
            cfg.AddProfile<UserModelMappingsProfile>();
        })
    )
);

builder.Services.AddServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks("/health", new HealthCheckOptions
{
    Predicate = _ => true
});

app.Run();
