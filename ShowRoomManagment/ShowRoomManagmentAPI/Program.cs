using Microsoft.EntityFrameworkCore;
using ShowRoomManagmentAPI.Controllers;
using ShowRoomManagmentAPI.Data;
using ShowRoomManagmentAPI.Models;
using ShowRoomManagmentAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);
var ApiAllow = "_apiAllow";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(x => x.AddPolicy(ApiAllow, policy=>{
    policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
   } ));
builder.Services.AddDbContext<ApplicationDbContext>
    (x => x.UseSqlServer(builder.Configuration.GetConnectionString("default")));

//------Model Dependancies----

builder.Services.AddScoped<IDepartment,DepartmentModel>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(ApiAllow);
app.UseAuthorization();

app.MapControllers();

app.Run();
