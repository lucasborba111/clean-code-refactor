using clean_code_refactor;
using clean_code_refactor.Domain.Bases;
using clean_code_refactor.Domain.Services.Clientes;
using clean_code_refactor.Domain.Services.Clientes.Validations;
using clean_code_refactor.Domain.Services.Reservas;
using clean_code_refactor.Domain.Services.Reservas.Validations;
using clean_code_refactor.Domain.ViewModels;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IReservaService, ReservaService>();
builder.Services.AddScoped<IValidation<CriarClienteViewModel>, ClienteValidation>();
builder.Services.AddScoped<IValidation<ReservaViewModel>, ReservaValidation>();

builder.Services.AddInfraSql(builder.Configuration);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
