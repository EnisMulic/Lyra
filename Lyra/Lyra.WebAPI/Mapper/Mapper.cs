using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Track, Model.Track>();
            CreateMap<Database.Track, Model.Requests.TrackUpsertRequest>().ReverseMap();

            CreateMap<Database.Album, Model.Album>();
            CreateMap<Database.Album, Model.Requests.AlbumUpsertRequest>().ReverseMap();
            CreateMap<Database.AlbumTrack, Model.AlbumTrack>();

            CreateMap<Database.Artist, Model.Artist>();
            CreateMap<Database.Artist, Model.Requests.ArtistUpsertRequest>().ReverseMap();

            CreateMap<Database.Playlist, Model.Playlist>();
            CreateMap<Database.Playlist, Model.Requests.PlaylistUpsertRequest>().ReverseMap();
            CreateMap<Database.PlaylistTrack, Model.PlaylistTrack>();

            CreateMap<Database.User, Model.User>();
            CreateMap<Database.User, Model.Requests.UserInsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.Requests.UserUpdateRequest>().ReverseMap();

            CreateMap<Database.UserRole, Model.UserRoles>();
            CreateMap<Database.Role, Model.Role>();

            CreateMap<Database.Genre, Model.Genre>();
            CreateMap<Database.TrackGenre, Model.TrackGenre>();
            CreateMap<Database.TrackArtist, Model.TrackArtist>();
        }

        
    }
}
