using System;
using MusicPodcast.Models;

namespace MusicPodcast.Repositories
{
    public interface IPlaylistRepository
    {
        // get playlist
        public Task<List<Playlist>> GetPlaylistsAsync();
        public Task<Playlist> GetPlaylistAsync(string id);
        // create playlist
        public Task<string> CreatePlaylistAsync(Playlist playlist);
        // update playlist
        public Task<string> UpdatePlaylistAsync(string id, Playlist playlist);
        // delete playlist
        public Task<string> DeletePlaylistAsync(string id);
        // get playlist items
        public Task<List<Track>> GetPlaylistItemsAsync(string id);
        // add items to playlist
        public Task<Track> AddItemsToPlaylistAsync(string id, Track track);
        // remove playlist items
        public Task<string> RemoveItemsPlaylistAsync(string idTrack, string idPlaylist);
    }
}

