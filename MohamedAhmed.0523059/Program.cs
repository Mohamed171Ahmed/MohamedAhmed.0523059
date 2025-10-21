using Microsoft.EntityFrameworkCore;
using MohamedAhmed._0523059.Data;
using MohamedAhmed._0523059.Repository.Imp;
using MohamedAhmed._0523059.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.
UseSqlServer(builder.Configuration.GetConnectionString("mo")));

builder.Services.AddScoped(typeof(IgenaricRepo<>), typeof(GenaricRepo<>));
builder.Services.AddScoped<IPlayersRepo, playersRepo>();
builder.Services.AddScoped<ICoachRepo , CoachRepo>();
builder.Services.AddScoped<IteamRepo , TeamRepo>();
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




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
