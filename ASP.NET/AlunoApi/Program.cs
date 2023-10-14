using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AlunoApi.Data;
var builder = WebApplication.CreateBuilder(args);
    
builder.Services.AddDbContext<AlunoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AlunoDbContext") ?? throw new InvalidOperationException("Connection string 'AlunoDbContext' not found.")));

// Add services to the container.

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

// Enable CORS
app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

