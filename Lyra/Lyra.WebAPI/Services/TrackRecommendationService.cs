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
    public class TrackRecommendationService : IRecommendationService<Model.Track>
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
            var userTrackReviews = await _context.UserTrackReviews
                .Where(i => i.UserID == UserID)
                .ToListAsync();


            var recommendedTracks = new List<Tuple<double, Database.Track>>();

            var reviews1 = new List<Database.UserTrackReview>();
            var reviews2 = new List<Database.UserTrackReview>();
            
            foreach(var userTrackReview in userTrackReviews)
            {
                var currentTrackReviews = await _context.UserTrackReviews.Where(i => i.TrackID == userTrackReview.TrackID).ToListAsync();
                var trackReviews = await GetReviews(userTrackReview.TrackID);

                foreach (var trackReview in trackReviews)
                {
                    foreach(var currentTrackReview in currentTrackReviews)
                    {
                        if(trackReview.Value.Where(i => i.UserID == currentTrackReview.UserID).Count() > 0)
                        {
                            reviews1.Add(currentTrackReview);
                            reviews2.Add(trackReview.Value.Where(i => i.UserID == currentTrackReview.UserID).FirstOrDefault());
                        }
                    }
                }

                double similarity = GetSimilarity(reviews1, reviews2);
                if(similarity > 0.5)
                {
                    var track = await _context.Tracks
                        .Include(i => i.TrackArtists)
                        .ThenInclude(i => i.Artist)
                        .Where(i => i.ID == userTrackReview.TrackID)
                        .FirstOrDefaultAsync();

                    recommendedTracks.Add(new Tuple<double, Database.Track>(similarity, track));
                }

                reviews1.Clear();
                reviews2.Clear();
            }



            var recommendedTracksQuery = recommendedTracks.OrderBy(i => i.Item1).Select(i => i.Item2).AsQueryable();
            recommendedTracksQuery = recommendedTracksQuery.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                recommendedTracksQuery = recommendedTracksQuery.Take(request.ItemsPerPage);
            }

            var recommendedTracksList = recommendedTracksQuery.ToList();
            return _mapper.Map<List<Model.Track>>(recommendedTracksList);
        }

        private double GetSimilarity(List<Database.UserTrackReview> reviews1, List<Database.UserTrackReview> reviews2)
        {
            if(reviews1.Count() == reviews2.Count())
            {
                double numarator = 0, denominator1 = 0, denominator2 = 0;
                for(int i = 0; i < reviews1.Count(); i++)
                {
                    numarator += reviews1[i].Score * reviews2[i].Score;
                    denominator1 += Math.Pow(reviews1[i].Score, 2);
                    denominator2 += Math.Pow(reviews2[i].Score, 2);
                }

                denominator1 = Math.Sqrt(denominator1);
                denominator2 = Math.Sqrt(denominator2);

                double denominator = denominator1 * denominator2;
                if (denominator == 0) return 0;

                return numarator / denominator;

            }

            return 0;
        }

        private async Task<Dictionary<int, List<Database.UserTrackReview>>> GetReviews(int TrackID)
        {
            var trackDictionary = new Dictionary<int, List<Database.UserTrackReview>>();
            List<Database.Track> tracks = await _context.Tracks
                .Where(i => i.ID != TrackID)
                .ToListAsync();

            foreach (var track in tracks)
            {
                var trackReviews = await _context.UserTrackReviews
                    .Where(i => i.TrackID == track.ID)
                    .OrderBy(i => i.UserID)
                    .ToListAsync();

                if (trackReviews != null)
                {
                    trackDictionary.Add(track.ID, trackReviews);
                }
            }

            return trackDictionary;
        }
    }
}
