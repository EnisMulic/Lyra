using AutoMapper;
using Lyra.Model;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class ReviewService : CRUDService<Model.UserTrackReview, UserTrackReviewSearchRequest, Database.UserTrackReview, UserTrackReviewUpsertRequest, UserTrackReviewUpsertRequest>
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public ReviewService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.UserTrackReview>> Get(UserTrackReviewSearchRequest search)
        {
            var query =  _context.UserTrackReviews.AsQueryable();

            if(search.UserID != 0)
            {
                query = query.Where(i => i.UserID == search.UserID);
            }

            if(search.TrackID != 0)
            {
                query = query.Where(i => i.TrackID == search.TrackID);
            }

            if(search.Score != 0)
            {
                query = query.Where(i => i.Score == search.Score);
            }

            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.UserTrackReview>>(list);
        }
    }
}
