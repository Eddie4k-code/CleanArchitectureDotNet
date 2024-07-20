using HRManagement.Application;
using HRManagement.Persistence;
using HRManagement.Infrastructure;
using HRManagement.Persistence.DatabaseContext;



var builder = WebApplication.CreateBuilder(args);

// Inject Services

builder.Services.AddApplicationServices();
builder.Services.ConfigureInfrastructureServices(builder.Configuration);
builder.Services.AddPersistenceServices(builder.Configuration);


builder.Services.AddControllers();

builder.Services.AddCors(options => {options.AddPolicy("all", builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());});

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

