using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MusicPodcast.Services.utils;

namespace MusicPodcast.Models
{
    public class ArtistTrack
    {
        public DateTime createAt { get; set; }
        public DateTime updateOn { get; set; }
        public string ID { get; set; }
        public ICollection<Track>? tracks { get; set; }
        public ICollection<User>? users { get; set; }
        public ArtistTrack()
        {

            IdAutoGenerate idAutoGenerate = new IdAutoGenerate();
            ID = idAutoGenerate.GenerateId("artisttrack");
            createAt = DateTime.Now;
            updateOn = DateTime.Now;

        }
    }
}

