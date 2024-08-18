using Microsoft.EntityFrameworkCore;
using Trades_Categories.Data.Interfaces;
using Trades_Categories.Data.Mappings;
using Trades_Categories.Data.Repositories;
using Trades_Categories.InfraStructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<Context>();
builder.Services.AddTransient<ICategoriesRules, CategoriesRules>();
builder.Services.AddTransient<ITrade, Trades>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(DTOToEntitiesMappingProfile));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
