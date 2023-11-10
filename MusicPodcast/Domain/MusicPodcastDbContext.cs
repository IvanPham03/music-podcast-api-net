using MusicPodcast.Models;

using Microsoft.EntityFrameworkCore;
using CsvHelper;
using System.Diagnostics;

namespace MusicPodcast.Data
{
    public class MusicPodcastDbContext : DbContext
    {
        public MusicPodcastDbContext(DbContextOptions<MusicPodcastDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Track> Track { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<ArtistFollower> ArtistFollower { get; set; }
    }
}
