
using MusicPodcast.Data;
using Microsoft.EntityFrameworkCore;
using MusicPodcast.Domain.data;
using MusicPodcast.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Register Library Service to use it with Dependency Injection in Controllers
builder.Services.AddTransient<IPlaylistRepository, PlaylistRepository>();
// Register database
builder.Services.AddDbContext<MusicPodcastDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MusicPodcastApiConnectionStrings")));
//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
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
//app cors
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("corsapp");
app.UseAuthorization();
app.MapControllers();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<MusicPodcastDbContext>();
    // Xóa cơ sở dữ liệu nếu nó đã tồn tại
    dbContext.Database.EnsureDeleted();
    // Tự động tạo hoặc cập nhật cơ sở dữ liệu
    dbContext.Database.Migrate();
    // Kiểm tra xem database có dữ liệu hay không và seed data nếu cần
    //if (!dbContext.Track!.Any())
    //{
    //    InitTrack.seedData(dbContext);

    //}
}

app.Run();
