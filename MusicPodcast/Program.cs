
using MusicPodcast.Data;
using Microsoft.EntityFrameworkCore;
using MusicPodcast.Domain.data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MusicPodcastDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MusicPodcastApiConnectionStrings")));
var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<MusicPodcastDbContext>();


    // Kiểm tra xem database có dữ liệu hay không và seed data nếu cần
    if (!dbContext.Track!.Any())
    {
        InitTrack.seedData(dbContext);

    }
}

app.Run();
