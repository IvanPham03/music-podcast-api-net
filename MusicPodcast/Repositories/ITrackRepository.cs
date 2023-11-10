using System;
using MusicPodcast.Models;
namespace MusicPodcast.Repositories
{
    public interface ITrackRepository
    {
        public Task<Track> GetTrackById(string id);
        public Task<List<Track>> GetAllTracks();
        public Task<string> CreateTrack(Track track);
        public Task<string> UpdateTrack(string id, Track track);
        public Task<string> DeleteTrack(string id);
    }
}

