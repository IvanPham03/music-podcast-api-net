using System;
using System.ComponentModel.DataAnnotations;
using MusicPodcast.Services.utils;

namespace MusicPodcast.Models
{
    public class Playlist
    {
        [Key]
        public string ID { get; set; }
        public string? description { get; set; }
        public string? imgPath { get; set; } = null;
        public string name { get; set; }
        public DateTime updateOn { get; set; }
        public DateTime createAt { get; set; }
        // foreign
        public string? playlistTrackId { get; set; }
        public PlaylistTrack? playlistTrack { get; set; }

        // foreign
        public string? playlistUserId { get; set; }
        public UserPlaylist? UserPlaylists { get; set; }


        public Playlist()
        {
            IdAutoGenerate idAutoGenerate = new IdAutoGenerate();
            ID = idAutoGenerate.GenerateId("playlist");
            updateOn = DateTime.Now;
            createAt = DateTime.Now;
        }
    }
}

