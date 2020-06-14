using AutoMapper;
using Lyra.Model;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class TrackRecommendationService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;

        public TrackRecommendationService(LyraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Model.Track>> Recommend(int UserID, PageRequest request)
        {
            var Tracks = await GetAllTracks();
            Tracks = Tracks.Skip((request.Page - 1) * request.ItemsPerPage).ToList();
            if (request.ItemsPerPage > 0)
            {
                Tracks = Tracks.Take(request.ItemsPerPage).ToList();
            }
            return Tracks;

            var UserTracks = await GetUserTracks(UserID);

            var RecommendedList = new List<Model.Track>();
            foreach(var UserTrack in UserTracks)
            {
                var TrackArtists = UserTrack.TrackArtists.Select(i => i.Artist).ToList();
                var TrackGenre = UserTrack.TrackGenres.Select(i => i.Genre).ToList();
                foreach (var Artist in TrackArtists)
                {
                    var trackList = Tracks.Where(i => i.TrackArtists.Select(i => i.Artist).ToList().Contains(Artist)).ToList();
                    foreach(var Genre in TrackGenre)
                    {
                        trackList = trackList.Where(i => i.TrackGenres.Select(i => i.Genre).ToList().Contains(Genre)).ToList();
                    }

                    RecommendedList.AddRange(trackList);
                } 
            }

            return RecommendedList;
        }


        private async Task<List<Model.Track>> GetAllTracks()
        {
            var tracks = await _context.Tracks
                .Include(i => i.TrackArtists)
                .ThenInclude(i => i.Artist)
                .Take(20)
                .ToListAsync();

            return _mapper.Map<List<Model.Track>>(tracks);
        }

        private async Task<List<Model.Track>> GetUserTracks(int UserID)
        {
            var items = _context.UserActivityTracks
                .Where(i => i.UserID == UserID)
                .Include(i => i.Track.TrackArtists)
                .ThenInclude(i => i.Artist)
                .Select(i => i.Track)
                .Distinct()
                .AsQueryable();

            var tracks = await items.ToListAsync();

            return _mapper.Map<List<Model.Track>>(items);
        }
    }
}
