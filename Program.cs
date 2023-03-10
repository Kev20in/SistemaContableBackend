using APEC.ProyectoFinal.API;
using APEC.ProyectoFinal.API.Dal;
using APEC.ProyectoFinal.API.Repository;
using APEC.ProyectoFinal.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddTransient<IUnitOfWork, UnitOfWork>();
services.AddScoped<ISuperService, SuperService>();

services.AddDbContext<DatabaseContext>(opt =>
{
    opt.UseSqlServer("Data Source=localhost;Initial Catalog=proecto;Integrated Security=True;TrustServerCertificate=True");
});

services.AddCors(op => op.AddPolicy("AllowOriginPolicy", builder =>
                                                         builder.AllowAnyOrigin()
                                                                .AllowAnyMethod()
                                                                .AllowAnyHeader()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware(typeof(TrackingMiddleware));

app.UseCors("AllowOriginPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();