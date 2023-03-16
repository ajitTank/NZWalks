using Microsoft.EntityFrameworkCore;
using NZWalks.Data;
using NZWalks.Repository;
using NZWalks.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/*Doing the Dependency Injection for DataBase*/
builder.Services.AddDbContext<ApplicationDb>(opt => { opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); });

/*Doing the DI for Interface and of its Class*/
builder.Services.AddScoped<IRegionsRepository, RegionRepository>();

/*Doing the DI for the only class*/
builder.Services.AddScoped<RegionService>();

/*doing the DI for autoMapper and autoMapper reuired the scan of assembly*/
builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
