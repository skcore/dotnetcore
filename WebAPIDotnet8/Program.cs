using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebAPIDotnet8.Data;
using WebAPIDotnet8.Repository;
using WebAPIDotnet8.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICovidRespository, CovidEFRespository>();
builder.Services.AddScoped<ICovidRespository, CovidADORepository>();

builder.Services.AddTransient<ICovidLogDataService, CovidLogEFService>();
builder.Services.AddTransient<ICovidLogDataService, CovidLogADOService>();

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
