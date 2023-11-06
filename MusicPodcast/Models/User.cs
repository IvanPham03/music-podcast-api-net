using System.ComponentModel.DataAnnotations;

namespace MusicPodcast.Models
{
    public class User
    {
        [Key]
        public long id { get; set; }
        public string  userName { get; set; }
        public string  email { get; set; }
        public string  phoneNumber { get; set; }
        public string  password { get; set; }
        public string  pathImg { get; set; }
        public DateTime timestamp { get; set; }
        public string role { get; set; }
    }
}
