using System;
using System.ComponentModel.DataAnnotations;
using MusicPodcast.Services.utils;

namespace MusicPodcast.Models
{
    public class PlaylistTrack
    {
        public bool isOwner { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateOn { get; set; }
        public string ID { get; set; }
        // 1 - nhiều với track
        public ICollection<Track>? tracks { get; set; }
        // 1 - nhiều với playlist
        public ICollection<Playlist>? playlists { get; set; }

        public PlaylistTrack()
        {

            IdAutoGenerate idAutoGenerate = new IdAutoGenerate();
            ID = idAutoGenerate.GenerateId("playlisttrack");
            createAt = DateTime.Now;
            updateOn = DateTime.Now;

        }
    }
}

