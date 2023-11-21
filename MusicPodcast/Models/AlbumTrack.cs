using System;
using System.ComponentModel.DataAnnotations;
using MusicPodcast.Services.utils;

namespace MusicPodcast.Models
{
    public class AlbumTrack
    {
        public DateTime createAt { get; set; }
        public DateTime updateOn { get; set; }
        public string ID { get; set; }
        // relative
        public ICollection<Track>? tracks { get; set; }
        public ICollection<Album>? albums { get; set; }

        public AlbumTrack()
        {

            IdAutoGenerate idAutoGenerate = new IdAutoGenerate();
            ID = idAutoGenerate.GenerateId("albumtrack");
            createAt = DateTime.Now;
            updateOn = DateTime.Now;

        }
    }
}

