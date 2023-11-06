using MusicPodcast.Models;

using Microsoft.EntityFrameworkCore;

namespace MusicPodcast.Data
{
    public class MusicPodcastDbContext : DbContext
    {
        public MusicPodcastDbContext (DbContextOptions<MusicPodcastDbContext> options) : base(options) { }

        public DbSet<User> User{ get; set; }
    }
}
