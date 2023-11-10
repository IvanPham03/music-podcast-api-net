using System;
using Microsoft.EntityFrameworkCore;
using MusicPodcast.Data;
using MusicPodcast.Models;

namespace MusicPodcast.Domain.data
{
    public class InitTrack
    {
        public static void seedData(MusicPodcastDbContext dbContext)
        {
            // Kiểm tra xem database có dữ liệu hay không
            if (!dbContext.Track.Any())
            {
                // Tạo Artist
                var artist = new Artist
                {
                    ID = "artist1",
                    Followers = null,
                    Genres = "Artist Genres",
                    Href = "Artist Href",
                    Images = "Artist Images",
                    Name = "Artist Name",
                    Popularity = 80,
                    Type = "Artist Type",
                    Uri = "Artist Uri"
                };
                // Tạo Album
                var album = new Album
                {
                    ID_Album = "album1",
                    AlbumType = "Album Type",
                    TotalTracks = 2,
                    AvailableMarkets = "Available Markets",
                    Images = "Album Images",
                    Name = "Album Name",
                    ReleaseDate = DateTime.Now,
                    Type = "Album Type"

                };



                // Tạo danh sách 10 đối tượng Track mẫu
                var sampleTracks = new List<Track>(){
                new Track
                {
                    ID = "track1",
                    Album = new List<Album> {},
                    Artists = new List<Artist> {},
                    DurationMs = 300000, // Độ dài trong miligiây
                    Explicit = false,
                    Name = "Sample Track 1",
                    Popularity = 80,
                    PreviewUrl = "http://sampleurl.com/preview1",
                    TrackNumber = 1,
                    Type = "audio",
                    Uri = "http://sampleurl.com/track1",
                    IsLocal = false
                },
                new Track
                {
                    ID = "track2",
                    Album = new List<Album> {},
                    Artists = new List<Artist> {},
                    DurationMs = 240000, // Độ dài trong miligiây
                    Explicit = true,
                    Name = "Sample Track 2",
                    Popularity = 65,
                    PreviewUrl = "http://sampleurl.com/preview2",
                    TrackNumber = 2,
                    Type = "audio",
                    Uri = "http://sampleurl.com/track2",
                    IsLocal = false
                }
                };

                // Thêm dữ liệu vào database
                // Thêm Album và Artist vào database
                //dbContext.Artist.Add(artist);
                dbContext.Album.Add(album);
                //dbContext.Track.AddRange(sampleTracks);
                try
                {
                    // Code thực hiện thay đổi và lưu vào database
                    dbContext.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    // Xem chi tiết lỗi
                    var errorMessage = ex.InnerException?.Message;
                    Console.WriteLine("----------------------------------------" + errorMessage);
                }
            }
        }
        public InitTrack(MusicPodcastDbContext dbContext)
        {

        }
    }
}

