using System;
using MusicPodcast.Data;
using MusicPodcast.Models;
using MusicPodcast.Repositories;
using MusicPodcast.Services.utils;

namespace MusicPodcast.Services
{
    public class TrackService : ITrackRepository
    {
        private MusicPodcastDbContext _context;

        public TrackService(MusicPodcastDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateTrack(Track track)
        {
            if (track == null)
            {
                throw new ArgumentNullException(nameof(track));
            }
            // Thêm track mới vào cơ sở dữ liệu
            _context.Track.Add(track);
            await _context.SaveChangesAsync();

            // Sau khi thêm thành công, trả về ID của track vừa được tạo
            return track.ID;
        }

        public Task<string> DeleteTrack(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Track>> GetAllTracks()
        {
            throw new NotImplementedException();
        }

        public Task<Track> GetTrackById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateTrack(string id, Track track)
        {
            throw new NotImplementedException();
        }
    }
}

