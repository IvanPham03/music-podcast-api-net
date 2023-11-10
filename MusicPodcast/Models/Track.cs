using System;
using System.ComponentModel.DataAnnotations;

namespace MusicPodcast.Models
{
    public class Track
    {
        [Key]
        public string ID { get; set; }
        public List<Album> Album { get; set; }
        public List<Artist> Artists { get; set; }
        public int DurationMs { get; set; }
        public bool Explicit { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string PreviewUrl { get; set; }
        public int TrackNumber { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
        public bool IsLocal { get; set; }
    }
}

