using CameYA.Core.Interfaces;
using CameYA.Core.Interfaces.IServices;
using CameYA.Core.Services;
using CameYA.Infrastructure.Filters;
using CameYA.Infrastructure.Repositories;
using CameYA.Infrastructure.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Inyeccion de dependencias - Unit Of Work
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
// Inyeccion de dependencias - Worker Service
builder.Services.AddTransient<IWorkerService, WorkerService>();
// Registro mis mapeos con AutoMapper a nivel de ASM
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Middleware de validacion de modelos
builder.Services.AddMvc(opc =>
{
    opc.Filters.Add<ModelFilters>();
});

// Registro de validaciones de modelos
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<WorkerValidators>();
builder.Services.AddValidatorsFromAssemblyContaining<ServiceValidators>();
builder.Services.AddValidatorsFromAssemblyContaining<ClientValidators>();

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
