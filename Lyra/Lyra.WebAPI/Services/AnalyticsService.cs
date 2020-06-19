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
    public class AnalyticsService : IAnalyticsService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public AnalyticsService(LyraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Model.UserActivityAlbum>> GetActivityAlbums(PageRequest request)
        {
            var query = _context.UserActivityAlbums
                .Include(i => i.Album)
                .AsQueryable();

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.UserActivityAlbum>>(list);
        }

        public async Task<List<Model.UserActivityArtist>> GetActivityArtists(PageRequest request)
        {
            var query = _context.UserActivityArtists
                .Include(i => i.Artist)
                .AsQueryable();

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.UserActivityArtist>>(list);
        }

        public async Task<List<Model.UserActivityPlaylist>> GetActivityPlaylists(PageRequest request)
        {
            var query = _context.UserActivityPlaylists
                .Include(i => i.Playlist)
                .AsQueryable();

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.UserActivityPlaylist>>(list);
        }

        public async Task<List<Model.UserActivityTrack>> GetActivityTracks(PageRequest request)
        {
            var query = _context.UserActivityTracks
                .Include(i => i.Track)
                .AsQueryable();

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.UserActivityTrack>>(list);
        }
    }
}
