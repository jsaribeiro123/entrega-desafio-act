using System.Net;
using AutoMapper;

using Wallet.NFT.DAL;
using Wallet.NFT.Domain;
using Wallet.NFT.Service;

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));

//IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
//builder.Services.AddSingleton(mapper);

//builder.Services.AddScoped<ILancamentoRepository, LancamentoRepository>();

//builder.Services.AddScoped<ILancamentoService, LancamentoService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "NFT.Api",
        Description = "",
        TermsOfService = new Uri("http://localhost:5122"),
        Contact = new OpenApiContact
        {
            Name = "José Ribeiro",
            Email = "jsribeiro123@gmail.com",
            Url = new Uri("http://localhost:5122")
        },
        License = new OpenApiLicense
        {
            Name = "",
            Url = new Uri("https://localhost:7083")
        }
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();


/*
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));
// Add services to the container.

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "NFT.Api",
        Description = "",
        TermsOfService = new Uri("https://"),
        Contact = new OpenApiContact
        {
            Name = "José Ribeiro",
            Email = "jsribeiro123@gmail.com",
            Url = new Uri("")
        },
        License = new OpenApiLicense
        {
            Name = "",
            Url = new Uri("https://")
        }
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseErrorHandlerMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    try
//    {
//        var dbContext = services.GetRequiredService<ApplicationDbContext>();
//        if (dbContext.Database.IsSqlServer())
//        {
//            dbContext.Database.Migrate();
//        }
//    }
//    catch (Exception ex)
//    {
//        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

//        logger.LogError(ex, "An error occurred while migrating or seeding the database.");

//        throw;
//    }
//}

app.MapControllers();

app.Run();

*/