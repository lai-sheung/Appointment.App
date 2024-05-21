using Appointment.App.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{
    var services = builder.Services;
    var cfg = builder.Configuration;
    var env = builder.Environment;
    // Add services to the container.
    services.AddDbContext<AppointmentContext>();

    services.AddCors();
    services.AddControllers();
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// configure HTTP request pipeline
{
    // global cors policy
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    app.MapControllers();
}

app.Run();
