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
    public class TrackService : CRUDService<Model.Track, TrackSearchRequest, Database.Track, TrackUpsertRequest, TrackUpsertRequest>
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;

        public TrackService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.Track>> Get(TrackSearchRequest request)
        {
            var query = _context.Tracks
                .Include(i => i.TrackArtists)
                .ThenInclude(i => i.Artist)
                .Include(i => i.TrackGenres)
                .Select
                (
                    i => new Model.Track()
                    {
                        ID = i.ID,
                        Name = i.Name,
                        Length = i.Length.ToString(@"hh\:mm\:ss")
                    }
                )
                .AsQueryable();

            //if(request.ArtistID != 0)
            //{
            //    query = query.Where(i => i.TrackArtists
            //        .Where(j => j.ArtistID == j.ArtistID)
            //        .Select(j => j.ArtistID)
            //        .Contains(request.ArtistID));
            //}

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(request.Name));
            }

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.Track>>(list);
        }

        public override async Task<Model.Track> GetById(int ID)
        {
            var entity = await _context.Tracks
                .Include(i => i.TrackArtists)
                .ThenInclude(i => i.Artist)
                .Include(i => i.TrackGenres)
                .SingleOrDefaultAsync(i => i.ID == ID);

            return _mapper.Map<Model.Track>(entity);
        }

        public override async Task<Model.Track> Insert(TrackUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Track>(request);

            await _context.Tracks.AddAsync(entity);
            await _context.SaveChangesAsync();

            var mainTrackArtist = new Database.TrackArtist()
            {
                TrackID = entity.ID,
                ArtistID = request.MainArtist,
                TrackArtistRole = TrackArtistRole.Main
            };
            await _context.TrackArtists.AddAsync(mainTrackArtist);
            await _context.SaveChangesAsync();

            foreach (var ArtistID in request.FeaturedArtists)
            {
                var trackArtist = new Database.TrackArtist()
                {
                    TrackID = entity.ID,
                    ArtistID = ArtistID,
                    TrackArtistRole = TrackArtistRole.Feature
                };
                await _context.TrackArtists.AddAsync(trackArtist);
            }

            foreach (var GenreID in request.Genres)
            {
                var trackGenre = new Database.TrackGenre()
                {
                    TrackID = entity.ID,
                    GenreID = GenreID
                };
                await _context.TrackGenres.AddAsync(trackGenre);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Track>(entity);
        }

        public override async Task<Model.Track> Update(int id, TrackUpsertRequest request)
        {
            var entity = _context.Tracks.Find(id);
            _context.Tracks.Attach(entity);
            _context.Tracks.Update(entity);

            entity.MP3File = request.MP3File;

            foreach (var ArtistID in request.ArtistsToDelete)
            {
                var trackArtist = await _context.TrackArtists
                    .Where(i => i.TrackID == id && i.ArtistID == ArtistID)
                    .SingleOrDefaultAsync();

                if (trackArtist != null)
                {
                    _context.Set<Database.TrackArtist>().Remove(trackArtist);
                }
            }
            await _context.SaveChangesAsync();

            foreach (var ArtistID in request.FeaturedArtists)
            {
                var trackArtist = await _context.TrackArtists
                    .Where(i => i.TrackID == id && i.ArtistID == ArtistID)
                    .SingleOrDefaultAsync();

                if (trackArtist == null)
                {
                    var newTrackArtist = new Database.TrackArtist()
                    {
                        TrackID = id,
                        ArtistID = ArtistID,
                        TrackArtistRole = TrackArtistRole.Feature
                    };
                    await _context.Set<Database.TrackArtist>().AddAsync(newTrackArtist);
                }
            }
            await _context.SaveChangesAsync();


            var tracMainkArtist = await _context.TrackArtists
                    .Where(i => i.TrackID == id && i.TrackArtistRole == TrackArtistRole.Main)
                    .SingleOrDefaultAsync();

            if (tracMainkArtist == null)
            {
                var newTrackArtist = new Database.TrackArtist()
                {
                    TrackID = id,
                    ArtistID = request.MainArtist,
                    TrackArtistRole = TrackArtistRole.Main
                };
                await _context.Set<Database.TrackArtist>().AddAsync(newTrackArtist);
            }
            else
            {
                tracMainkArtist.ArtistID = request.MainArtist;
            }
            await _context.SaveChangesAsync();




            foreach (var GenreID in request.Genres)
            {
                var trackGenre = await _context.TrackGenres
                    .Where(i => i.TrackID == id && i.GenreID == GenreID)
                    .SingleOrDefaultAsync();

                if (trackGenre == null)
                {
                    var newTrackArtist = new Database.TrackGenre()
                    {
                        TrackID = id,
                        GenreID = GenreID,
                    };
                    await _context.Set<Database.TrackGenre>().AddAsync(newTrackArtist);
                }
            }

            foreach (var GenreID in request.GenresToDelete)
            {
                var trackGenre = await _context.TrackGenres
                    .Where(i => i.TrackID == id && i.GenreID == GenreID)
                    .SingleOrDefaultAsync();

                if (trackGenre != null)
                {
                    _context.Set<Database.TrackGenre>().Remove(trackGenre);
                }
            }

            return _mapper.Map<Model.Track>(entity);
        }
    }

}
