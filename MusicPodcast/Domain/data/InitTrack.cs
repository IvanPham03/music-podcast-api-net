using System;
using Microsoft.EntityFrameworkCore;
using MusicPodcast.Data;
using MusicPodcast.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MusicPodcast.Domain.data
{
    public class InitTrack
    {
        //public static async void seedData(MusicPodcastDbContext dbContext)
        //{
        //    // Kiểm tra xem database có dữ liệu hay không
        //    if (!dbContext.Track.Any())
        //    {
        //        // Tạo danh sách 10 đối tượng Track mẫu
        //        var sampleTracks = new List<Track>{
        //        new Track
        //        {
        //            ID = "01",
        //            Album = new List<Album>{
        //               new Album
        //               {
        //                    ID = "album01",
        //                    AlbumType = "genz",
        //                    AvailableMarkets = 100,
        //                    Images= "",
        //                    Name = "album 01",
        //                    CreateAt = DateTime.Now,
        //                    UpdateAt = DateTime.Now
        //               },
        //               new Album
        //               {
        //                    ID = "album03",
        //                    AlbumType = "genz",
        //                    AvailableMarkets = 100,
        //                    Images= "",
        //                    Name = "album 01",
        //                    CreateAt = DateTime.Now,
        //                    UpdateAt = DateTime.Now
        //               }
        //            },
        //            Artists = new List<Artist>
        //            {
        //                new Artist
        //                {
        //                    ID = "artist01",
        //                    Genres = "Ballad",
        //                    Images = "",
        //                    Name = "HỒ Quang Hiếu",
        //                    Popularity = 0,
        //                    Type = "",
        //                    Uri = "",
        //                    CreateAt = DateTime.Now,
        //                    UpdateAt = DateTime.Now
        //                }

        //            },
        //            Name = "Anh Đã Yên Bình Tôi Biết Thương Mình",
        //            Popularity = 80,
        //            Type = "audio",
        //            Url = "AnhDaYenBinhToiBietThuongMinh-PhamQuynhAnh-9010380.mp3",
        //            IsLocal = false
        //        },
        //        new Track
        //        {
        //             ID = "02",
        //            Album = new List<Album>{
        //               new Album
        //               {
        //                   ID = "album02",
        //                AlbumType = "genz",
        //                AvailableMarkets = 100,
        //                Images= "",
        //                Name = "album 01",
        //                CreateAt = DateTime.Now,
        //                UpdateAt = DateTime.Now
        //               }
        //            },
        //            Artists = new List<Artist>
        //            {
        //                new Artist
        //                {
        //                    ID = "artist02",
        //                    Genres = "Ballad",
        //                    Images = "",
        //                    Name = "HỒ Quang Hiếu",
        //                    Popularity = 0,
        //                    Type = "",
        //                    Uri = "",
        //                    CreateAt = DateTime.Now,
        //                    UpdateAt = DateTime.Now
        //                }

        //            },
        //            Name = "Anh sẽ đưa em về",
        //            Popularity = 80,
        //            Type = "audio",
        //            Url = "AnhSeDuaEmVe-NQP-6309479.mp3",
        //            IsLocal = false
        //        }
        //        };
        //        dbContext.Track.AddRange(sampleTracks);
        //        try
        //        {
        //            // Code thực hiện thay đổi và lưu vào database
        //            dbContext.SaveChanges();
        //        }
        //        catch (DbUpdateException ex)
        //        {
        //            // Xem chi tiết lỗi
        //            var errorMessage = ex.InnerException?.Message;
        //            Console.WriteLine("----------------------------------------" + errorMessage);
        //        }
        //    }
        //}
        public InitTrack(MusicPodcastDbContext dbContext)
        {

        }
    }
}

