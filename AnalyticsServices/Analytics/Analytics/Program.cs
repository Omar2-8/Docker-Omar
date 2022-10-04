using Analytics.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container.
builder.Services.AddDbContext<NumbersDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefultConnectionStrings")));

builder.Services.AddDbContext<AnalyticsDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("SecondConnectionStrings")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("EnableCORS", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
}); 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<NumbersDbContext>();
    db.Database.Migrate();
    var db1 = scope.ServiceProvider.GetRequiredService<AnalyticsDbContext>();
    db1.Database.Migrate();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());



app.UseCors("EnableCORS");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
