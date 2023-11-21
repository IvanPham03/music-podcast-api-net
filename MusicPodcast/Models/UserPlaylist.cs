using System;
using System.ComponentModel.DataAnnotations;
using MusicPodcast.Services.utils;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MusicPodcast.Models
{
    public class UserPlaylist
    {
        public DateTime createAt { get; set; }
        public DateTime updateOn { get; set; }
        public string ID { get; set; }
        //1 nhieu voi user
        public ICollection<User>? users { get; set; }
        public ICollection<Playlist>? playlists { get; set; }
        public UserPlaylist()
        {
            IdAutoGenerate idAutoGenerate = new IdAutoGenerate();
            ID = idAutoGenerate.GenerateId("userplaylist");
            createAt = DateTime.Now;
            updateOn = DateTime.Now;
        }
    }
}

