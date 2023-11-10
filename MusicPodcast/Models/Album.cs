using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MusicPodcast.Models
{
    public class Album
    {
        [Key]
        public string ID_Album { get; set; }
        public string AlbumType { get; set; }
        public int TotalTracks { get; set; }
        public string AvailableMarkets { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
    }
}
