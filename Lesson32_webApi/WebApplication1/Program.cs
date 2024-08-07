using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using WebApplication1;
using WebApplication1.Data;
using WebApplication1.Services;
using WebApplication1.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<ISingleton, Class>();
builder.Services.AddScoped<IScoped, Class>();
builder.Services.AddTransient<ITransient, Class>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(options => // <--- Setup logging
{
    // Specify all that you need here:
    options.LoggingFields = HttpLoggingFields.RequestHeaders |
                            HttpLoggingFields.RequestBody |
                            HttpLoggingFields.ResponseHeaders |
                            HttpLoggingFields.ResponseBody;
});
builder.Services.Configure<PositionOptions>(builder.Configuration.GetSection(PositionOptions.Position));
builder.Services.AddDbContext<StudentDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHello();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
