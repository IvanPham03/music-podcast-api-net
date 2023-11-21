using System;
using System.ComponentModel.DataAnnotations;
using MusicPodcast.Services.utils;

namespace MusicPodcast.Models
{
    public class Track
    {
        [Key]
        public string ID { get; set; }
        public string name { get; set; }
        public string? type { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateOn { get; set; }
        public string genre { get; set; }
        public string url { get; set; }

        // user
        public ICollection<User>? users { get; set; }
        // khoá ngoại playlistTrack
        public string? trackPlaylistId { get; set; }
        public PlaylistTrack? playlistTrack { get; set; }

        // khoa ngoai artisttrack
        public string? artistTrackId { get; set; }
        public ArtistTrack? artistTrack { get; set; }

        // khoá ngoại albumTrack
        public string? albumTrackId { get; set; }
        public AlbumTrack? albumTrack { get; set; }

        public Track()
        {
            IdAutoGenerate idAutoGenerate = new IdAutoGenerate();
            ID = idAutoGenerate.GenerateId("track");
            createAt = DateTime.Now;
            updateOn = DateTime.Now;
        }

    }
}

