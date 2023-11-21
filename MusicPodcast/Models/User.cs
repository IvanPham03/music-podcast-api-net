using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using MusicPodcast.Services.utils;

namespace MusicPodcast.Models
{
    //[Table("User")]
    public class User
    {
        //[Key]
        public string ID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string? phoneNumber { get; set; }
        public string password { get; set; }
        public string? pathImg { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateOn { get; set; }
        public string role { get; set; }

        // khoa ngoai
        public Track? tracks { get; set; }
        public string? trackId { get; set; }

        // khoa ngoai
        public UserPlaylist? userPlaylists { get; set; }
        public string? userPlayslistId { get; set; }

        // khoa ngoai
        public string? artistTrackId { get; set; }
        public ArtistTrack? artistTrack { get; set; }

        public User()
        {
            IdAutoGenerate idAutoGenerate = new IdAutoGenerate();
            ID = idAutoGenerate.GenerateId("user");
            createAt = DateTime.Now;
            updateOn = DateTime.Now;
            phoneNumber = null;
            pathImg = null;
            role = "user";
        }
    }

}
