using System;
using System.ComponentModel.DataAnnotations;

namespace MusicPodcast.Models
{
    public class ArtistFollower
    {
        [Key]
        public string ID { get; set; }
        public string Href { get; set; }
        public int Total { get; set; }
    }
}

