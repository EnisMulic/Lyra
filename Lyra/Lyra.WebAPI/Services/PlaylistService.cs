using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class PlaylistService : CRUDService<Model.Playlist, PlaylistSearchRequest, Database.Playlist, PlaylistUpsertRequest, PlaylistUpsertRequest>, IPlaylistService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public PlaylistService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Model.Track>> GetTracks(int ID)
        {
            var list = await _context.PlaylistTracks
                .Include(i => i.Track)
                .Where(i => i.PlaylistID == ID)
                .Select(i => i.Track)
                .ToListAsync();

            return _mapper.Map<List<Model.Track>>(list);
        }
    }
}
