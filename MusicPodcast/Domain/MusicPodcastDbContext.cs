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
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<ArtistTrack> ArtistTrack { get; set; }
        public DbSet<UserPlaylist> UserPlaylist { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // has no key
            builder.Entity<AlbumTrack>().HasKey(k => k.ID);
            builder.Entity<ArtistTrack>().HasKey(k => k.ID);
            builder.Entity<PlaylistTrack>().HasKey(k => k.ID);
            builder.Entity<UserPlaylist>().HasKey(k => k.ID);

            //user - userplaylist
            builder.Entity<User>().HasOne<UserPlaylist>(k => k.userPlaylists).WithMany(k => k.users).HasForeignKey(k => k.userPlayslistId).OnDelete(DeleteBehavior.NoAction);

            //user - track
            builder.Entity<User>().HasOne<Track>(k => k.tracks).WithMany(k => k.users).HasForeignKey(k => k.trackId).OnDelete(DeleteBehavior.NoAction);

            //playlist - userplaylist
            builder.Entity<Playlist>().HasOne<UserPlaylist>(k => k.UserPlaylists).WithMany(k => k.playlists).HasForeignKey(k => k.playlistUserId).OnDelete(DeleteBehavior.NoAction);

            //playlist - playlistTrack
            builder.Entity<Playlist>().HasOne<PlaylistTrack>(k => k.playlistTrack).WithMany(k => k.playlists).HasForeignKey(k => k.playlistTrackId).OnDelete(DeleteBehavior.NoAction);

            //track - playlistTrack
            builder.Entity<Track>().HasOne<PlaylistTrack>(k => k.playlistTrack).WithMany(k => k.tracks).HasForeignKey(k => k.trackPlaylistId).OnDelete(DeleteBehavior.NoAction);

            //track - artistTrack
            builder.Entity<Track>().HasOne<ArtistTrack>(k => k.artistTrack).WithMany(k => k.tracks).HasForeignKey(k => k.artistTrackId).OnDelete(DeleteBehavior.NoAction);

            //track - albumTrack
            builder.Entity<Track>().HasOne<AlbumTrack>(k => k.albumTrack).WithMany(k => k.tracks).HasForeignKey(k => k.albumTrackId).OnDelete(DeleteBehavior.NoAction);

            //user - artistTrack
            builder.Entity<User>().HasOne<ArtistTrack>(k => k.artistTrack).WithMany(k => k.users).HasForeignKey(k => k.artistTrackId).OnDelete(DeleteBehavior.NoAction);

            //album - albumTrack
            builder.Entity<Album>().HasOne<AlbumTrack>(k => k.albumTrack).WithMany(k => k.albums).HasForeignKey(k => k.albumTrackId).OnDelete(DeleteBehavior.NoAction);




            // init data user

            builder.Entity<User>().HasData(new User { userName = "truong", email = "truong@gmail.com", password = "admin" }, new User { userName = "truong2", email = "truong2@gmail.com", password = "admin2", role = "amdin" });
            // init track
            builder.Entity<Track>().HasData(new Models.Track { name = "Anh Đã Yên Bình Tôi Biết Thương Mình", genre = "nhạc trẻ", url = "AnhDaYenBinhToiBietThuongMinh-PhamQuynhAnh-9010380.mp3" },
                new Models.Track { name = "Anh sẽ đưa em về", genre = "nhạc trẻ", url = "AnhSeDuaEmVe-NQP-6309479.mp3" });
        }
    }
}
