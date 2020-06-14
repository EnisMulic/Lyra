using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Lyra.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class UserService : CRUDService<Model.User, UserSearchRequest, Database.User, UserInsertRequest, UserUpdateRequest>, IUserService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public UserService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.User>> Get(UserSearchRequest request)
        {
            var query = _context.Users.Include(i => i.UserRoles).AsQueryable();

            bool isRequestNull = !string.IsNullOrWhiteSpace(request.FirstName) || 
                                 !string.IsNullOrWhiteSpace(request.LastName) ||
                                 !string.IsNullOrWhiteSpace(request.Username) ||
                                 !string.IsNullOrWhiteSpace(request.Email);

            if (isRequestNull)
            {
                query = query.Where(i =>
                    (
                        !string.IsNullOrWhiteSpace(request.FirstName) &&
                        i.FirstName.StartsWith(request.FirstName)
                    ) ||
                    (
                        !string.IsNullOrWhiteSpace(request.LastName) &&
                        i.LastName.StartsWith(request.LastName)
                    ) ||
                    (
                        !string.IsNullOrWhiteSpace(request.Username) &&
                        i.Username.Equals(request.Username)
                    ) ||
                    (
                        !string.IsNullOrWhiteSpace(request.Email) &&
                        i.Email.Equals(request.Email)
                    )
                );
            }
            

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if(request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.User>>(list);
        }

        public override async Task<Model.User> GetById(int id)
        {
            var entity =  await _context.Set<Database.User>()
                .Include(i => i.UserRoles)
                .Where(i => i.ID == id)
                .SingleOrDefaultAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public async Task<Model.User> Authenticate(UserAuthenticationRequest request)
        {
            var user = await _context.Users
                .Include(i => i.UserRoles)
                .ThenInclude(j => j.Role)
                .FirstOrDefaultAsync(i => i.Username == request.Username);

            
            if (user != null)
            {
                var hash = GenerateHash(user.PasswordSalt, request.Password);
                if(hash == user.PasswordHash)
                {
                    return _mapper.Map<Model.User>(user);
                }
            }

            return null;
        }

        public static string GenerateSalt()
        {
            var buffer = new byte[16];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);

            return Convert.ToBase64String(buffer);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA512");
            byte[] inArray = algorithm.ComputeHash(dst);

            return Convert.ToBase64String(inArray);
        }

        public override async Task<Model.User> Insert(UserInsertRequest request)
        {
            if(request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            if(!await IsEmailUnique(request.Email))
            {
                throw new UserException("Email is taken!");
            }

            if(!await IsUsernameUnique(request.Username))
            {
                throw new UserException("Username is taken");
            }
            
            var entity = _mapper.Map<Database.User>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach(var roleID in request.Roles)
            {
                var role = new Database.UserRole()
                {
                    UserID = entity.ID,
                    RoleID = roleID
                };

                await _context.UserRoles.AddAsync(role);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public override async Task<Model.User> Update(int id, UserUpdateRequest request)
        {

            var entity = _context.Users.Find(id);

            if(entity.Email != request.Email && await IsEmailUnique(request.Email) == false)
            {
                throw new UserException("Email is taken!");
            }

            if (entity.Username != request.Username && await IsUsernameUnique(request.Username) == false)
            {
                throw new UserException("Username is taken");
            }


            
            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            if(!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwords do not match!");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            foreach(var RoleID in request.Roles)
            {
                var userRole = await _context.UserRoles
                    .Where(i => i.RoleID == RoleID && i.UserID == id)
                    .SingleOrDefaultAsync();

                if(userRole == null)
                {
                    var newRole = new Database.UserRole()
                    {
                        UserID = id,
                        RoleID = RoleID
                    };
                    await _context.Set<Database.UserRole>().AddAsync(newRole);
                }
            }


            foreach (var RoleID in request.RolesToDelete)
            {
                var userRole = await _context.UserRoles
                    .Where(i => i.RoleID == RoleID && i.UserID == id)
                    .SingleOrDefaultAsync();

                if (userRole != null)
                {
                    _context.Set<Database.UserRole>().Remove(userRole);
                }
            }

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public async Task<Model.User> SignUp(UserInsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            var entity = _mapper.Map<Database.User>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            var role = await _context.Roles
                .Where(i => i.Name == "User")
                .SingleAsync();


            var userRole = new Database.UserRole()
            {
                UserID = entity.ID,
                RoleID = role.ID
            };

            await _context.UserRoles.AddAsync(userRole);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public async Task<bool> IsEmailUnique(string Email)
        {
            return !await _context.Users.AnyAsync(i => i.Email == Email);
        }

        public async Task<bool> IsUsernameUnique(string Username)
        {
            return !await _context.Users.AnyAsync(i => i.Username == Username);
        }

        public async Task<List<Model.Track>> GetFavouriteTracks(int id, TrackSearchRequest request)
        {
            var query = _context.UserFavouriteTracks
                .Include(i => i.Track.TrackArtists)
                .ThenInclude(i => i.Artist)
                .Where(i => i.UserID == id)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Track.Name.StartsWith(request.Name));
            }

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.Track>>(list.Select(i => i.Track).ToList());
        }

        public async Task<List<Model.Album>> GetFavouriteAlbums(int id, AlbumSearchRequest request)
        {
            var query =  _context.UserFavouriteAlbums
                .Where(i => i.UserID == id)
                .Select(i => i.Album)
                .Select
                (
                    i => new Database.Album()
                    {
                        ID = i.ID,
                        Image = i.Image,
                        ReleaseYear = i.ReleaseYear,
                        Name = i.Name,
                        Artist = i.Artist
                    }
                )
                .AsQueryable();

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

            return _mapper.Map<List<Model.Album>>(list);
        }

        public async Task<List<Model.Artist>> GetFavouriteArtists(int id, ArtistSearchRequest request)
        {
            var query = _context.UserFavouriteArtists
                .Where(i => i.UserID == id)
                .Select(i => i.Artist)
                .AsQueryable();


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

            return _mapper.Map<List<Model.Artist>>(list);
        }

        public async Task<List<Model.UserActivityTrack>> GetActivityTracks(int id, TrackSearchRequest request)
        {
            var query =  _context.UserActivityTracks
                .Include(i => i.Track.TrackArtists)
                .ThenInclude(i => i.Artist)
                .Where(i => i.UserID == id)
                .OrderByDescending(i => i.InteractedAt)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Track.Name.StartsWith(request.Name));
            }

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.UserActivityTrack>>(list);
        }

        public async Task<List<Model.UserActivityAlbum>> GetActivityAlbums(int id, AlbumSearchRequest request)
        {
            var query =  _context.UserActivityAlbums
                .Where(i => i.UserID == id)
                .Include(i => i.Album)
                .OrderByDescending(i => i.InteractedAt)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Album.Name.StartsWith(request.Name));
            }

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.UserActivityAlbum>>(list);
        }

        public async Task<List<Model.UserActivityArtist>> GetActivityArtists(int id, ArtistSearchRequest request)
        {
            var query =  _context.UserActivityArtists
                .Where(i => i.UserID == id)
                .Include(i => i.Artist)
                .OrderByDescending(i => i.InteractedAt)
                .AsQueryable();


            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Artist.Name.StartsWith(request.Name));
            }

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();


            return _mapper.Map<List<Model.UserActivityArtist>>(list);
        }

        public async Task<List<Model.UserActivityPlaylist>> GetActivityPlaylists(int id, PlaylistSearchRequest request)
        {
            var query =  _context.UserActivityPlaylists
                .Where(i => i.UserID == id)
                .Include(i => i.Playlist)
                .OrderByDescending(i => i.InteractedAt)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Playlist.Name.StartsWith(request.Name));
            }

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if (request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.UserActivityPlaylist>>(list);
        }

        public async Task<Model.Track> InsertFavouriteTrack(int id, int TrackID)
        {
            var entity = new UserFavouriteTrack()
            {
                UserID = id,
                TrackID = TrackID
            };

            await _context.UserFavouriteTracks.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Track>(entity.Track);
        }

        public async Task<Model.Album> InsertFavouriteAlbum(int id, int AlbumID)
        {
            var entity = new UserFavouriteAlbum()
            {
                UserID = id,
                AlbumID = AlbumID
            };

            await _context.UserFavouriteAlbums.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Album>(entity);
        }

        public async Task<Model.Artist> InsertFavouriteArtist(int id, int ArtistID)
        {
            var entity = new UserFavouriteArtist()
            {
                UserID = id,
                ArtistID = ArtistID
            };

            var Entity = await _context.UserFavouriteArtists.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Artist>(entity);
        }

        public async Task<Model.UserActivityTrack> InsertActivityTrack(int id, UserActivityTrackInsertRequest request)
        {
            var entity = _mapper.Map<Database.UserActivityTrack>(request);
            entity.UserID = id;

            await _context.UserActivityTracks.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.UserActivityTrack>(entity);
        }

        public async Task<Model.UserActivityAlbum> InsertActivityAlbum(int id, UserActivityAlbumInsertRequest request)
        {
            var entity = _mapper.Map<Database.UserActivityAlbum>(request);
            entity.UserID = id;

            await _context.UserActivityAlbums.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.UserActivityAlbum>(entity);
        }

        public async Task<Model.UserActivityArtist> InsertActivityArtist(int id, UserActivityArtistInsertRequest request)
        {
            var entity = _mapper.Map<Database.UserActivityArtist>(request);
            entity.UserID = id;

            await _context.UserActivityArtists.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.UserActivityArtist>(entity);
        }

        public async Task<Model.UserActivityPlaylist> InsertActivityPlaylist(int id, UserActivityPlaylistInsertRequest request)
        {
            var entity = _mapper.Map<Database.UserActivityPlaylist>(request);
            entity.UserID = id;

            await _context.UserActivityPlaylists.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.UserActivityPlaylist>(entity);
        }

        public async Task<bool> DeleteFavouriteTrack(int id, int TrackID)
        {
            var entity = await _context.UserFavouriteTracks
                .Where(i => i.UserID == id && i.TrackID == TrackID)
                .SingleOrDefaultAsync();

            if(entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> DeleteFavouriteAlbum(int id, int AlbumID)
        {
            var entity = await _context.UserFavouriteAlbums
                .Where(i => i.UserID == id && i.AlbumID == AlbumID)
                .SingleOrDefaultAsync();

            if (entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> DeleteFavouriteArtist(int id, int ArtistID)
        {
            var entity = await _context.UserFavouriteArtists
                .Where(i => i.UserID == id && i.ArtistID == ArtistID)
                .SingleOrDefaultAsync();

            if (entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<List<Model.Track>> Recommend(int id, PageRequest request)
        {
            var Recommender = new TrackRecommendationService(_context, _mapper);
            var Recommendations = await Recommender.Recommend(id, request);

            return Recommendations;
        }
    }
}
