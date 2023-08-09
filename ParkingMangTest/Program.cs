using Microsoft.EntityFrameworkCore;
using ParkingMngV2.EfCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//tell the app you need to use The Postgres
builder.Services.AddDbContext<EF_DataContext>(//!!! import efcore
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("Ef_Postgres_Db"))//!!! import EntityFrameworkCore
    );


builder.Services.AddControllers();
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

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
