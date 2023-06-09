using DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DB CONNECTION 
builder.Services.AddDbContext<TiendaDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TiendaDB_Connection"));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<TiendaDBContext>();
    dataContext.Database.Migrate();
}

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
