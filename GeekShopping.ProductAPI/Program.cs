using AutoMapper;
using GeekShopping.ProductAPI.Config;
using GeekShopping.ProductAPI.Model.Context;
using GeekShopping.ProductAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DB");
builder.Services.AddDbContext<DbGeekShoppingContext>(options => options.UseSqlite(connectionString));

//convert um VO (value objet) para objeto e o inverso, de Objeto para VO - isso � importante para n�o expor o banco de dados
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        // c => {
        //     c.SwaggerEndpoint("/swagger/v1/swagger.json", "Geek API V1");
        //     c.RoutePrefix = string.Empty;
        // }
    );
}

app.UseAuthorization();

app.MapControllers();

app.Run();
