using Microsoft.EntityFrameworkCore;
using StartExplore.API.Mappings;
using StartExplore.API.Repositories;
using StartExploreAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnet/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); ;

builder.Services.AddDbContext<StartExploreDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StartExploreDbContext")));

builder.Services.AddScoped<IRegionRepository, SQLRegionReporsitory>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

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
