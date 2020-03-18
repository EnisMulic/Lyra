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
            CreateMap<Database.Track, Model.Requests.TrackInsertRequest>().ReverseMap();
            CreateMap<Database.Album, Model.Album>();
            CreateMap<Database.Album, Model.Requests.AlbumInsertRequest>().ReverseMap();
            CreateMap<Database.Artist, Model.Artist>();
            CreateMap<Database.Playlist, Model.Playlist>();
        }
    }
}
