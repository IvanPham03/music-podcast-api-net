using System;
using System.ComponentModel.DataAnnotations;

namespace MusicPodcast.Models
{
    public class Artist
    {
        [Key]
        public string ID { get; set; }
        public List<ArtistFollower> Followers { get; set; }
        public string Genres { get; set; }
        public string Href { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }
}

