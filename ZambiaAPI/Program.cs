using Microsoft.EntityFrameworkCore;
using ZambiaAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the Dependency Injection container which are used by the application.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add DbContext to the DI container : ZambiaDbContext
builder.Services.AddDbContext<ZambiaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ZambiaConnectionString"));
});

var app = builder.Build();


////  After the application has been built, it can be configured using the services that have been added to the DI container.
///// i.e middleware components can be added to the HTTP request pipeline.

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
