using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PCInfo_backend.Recommendations.Domain.Repositories;
using PCInfo_backend.Recommendations.Domain.Repositories.Users;
using PCInfo_backend.Recommendations.Mapping;
using PCInfo_backend.Recommendations.Persistence.Repositories;
using PCInfo_backend.Shared.Persistence.Contexts;
using PCInfo_backend.Shared.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add database connection

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySQL(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

// Add lowercase routes
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Automapper configuration
builder.Services.AddAutoMapper(typeof(ModelToResourceProfile), typeof(ResourceToModelProfile));

// Dependency Injection Configuration
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

// builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
/*builder.Services.AddScoped<ICPURepository, CPURepository>();
faltan los repos de todos menos el ProductoRepository, porfa hacerlo.
*/

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Validation for ensuring Database Objects are created
using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<AppDbContext>())
{
    context.Database.EnsureCreated();
}

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// Comments

/*
 SqlConnectionStringBuilder connectionStringBuilder = new();
connectionStringBuilder.DataSource = "MSI";
connectionStringBuilder.InitialCatalog = "pcinfo_db";
connectionStringBuilder.IntegratedSecurity = true;
var cs = connectionStringBuilder.ConnectionString;
 
 using (SqlConnection connection = new SqlConnection(cs))
{
    connection.Open();
    SqlCommand cmd = connection.CreateCommand();
    cmd.CommandText = "SELECT * FROM dbo.Productos";
    var reader = cmd.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine($"{reader["id"]} {reader["name"]} {reader["value"]}");
    }
} */
