using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using MusicPodcast.Services.utils;

namespace MusicPodcast.Models
{
    public class Album
    {
        [Key]
        public string ID { get; set; }
        public string albumType { get; set; }
        public string? image { get; set; }
        public string name { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateOn { get; set; }


        // khoa ngoai
        public string? albumTrackId { get; set; }
        public AlbumTrack? albumTrack { get; set; }
        public Album()
        {
            IdAutoGenerate idAutoGenerate = new IdAutoGenerate();
            ID = idAutoGenerate.GenerateId("album");
            createAt = DateTime.Now;
            updateOn = DateTime.Now;
        }
    }
}
