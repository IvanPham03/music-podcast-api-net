using System;
using Microsoft.EntityFrameworkCore;
using MusicPodcast.Data;
using MusicPodcast.Models;

namespace MusicPodcast.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly MusicPodcastDbContext _context;

        public PlaylistRepository(MusicPodcastDbContext context)
        {
            _context = context;
        }

        public Task<Track> AddItemsToPlaylistAsync(string id, Track track)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreatePlaylistAsync(Playlist playlist)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeletePlaylistAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Playlist> GetPlaylistAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Track>> GetPlaylistItemsAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Playlist>> GetPlaylistsAsync()
        {
            try
            {
                return await _context.Playlist.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task<string> RemoveItemsPlaylistAsync(string idTrack, string idPlaylist)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdatePlaylistAsync(string id, Playlist playlist)
        {
            throw new NotImplementedException();
        }
    }
}

