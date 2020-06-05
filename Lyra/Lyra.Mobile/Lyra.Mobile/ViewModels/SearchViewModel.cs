using Lyra.Mobile.Services;
using Lyra.Model;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        private readonly APIService _trackService = new APIService("Track");
        private readonly APIService _artistService = new APIService("Artist");
        private readonly APIService _albumService = new APIService("Album");
        private readonly APIService _playlistService = new APIService("Playlist");
        public ObservableCollection<TrackViewModel> TracksList { get; set; } = new ObservableCollection<TrackViewModel>();
        public ObservableCollection<ArtistViewModel> ArtistsList { get; set; } = new ObservableCollection<ArtistViewModel>();
        public ObservableCollection<AlbumViewModel> AlbumsList { get; set; } = new ObservableCollection<AlbumViewModel>();
        public ObservableCollection<Playlist> PlaylistsList { get; set; } = new ObservableCollection<Playlist>();
        public ICommand PerformSearch { get; set; }

        public SearchViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }


        private async Task Search(object query)
        {
            int itemsPerPage = 3;
            int page = 1;
            string queryString = query as string;

            var trackRequest = new TrackSearchRequest()
            {
                ItemsPerPage = itemsPerPage,
                Page = page,
                Name = queryString
            };
            var tracksList = await _trackService.Get<List<Model.Track>>(trackRequest);
            TracksList.Clear();
            foreach (var Item in tracksList)
            {
                TracksList.Add(new TrackViewModel(Item));
            }

            var albumRequest = new AlbumSearchRequest()
            {
                ItemsPerPage = itemsPerPage,
                Page = page,
                Name = queryString
            };
            var albumsList = await _albumService.Get<List<Model.Album>>(albumRequest);
            AlbumsList.Clear();
            foreach (var Item in albumsList)
            {
                AlbumsList.Add(new AlbumViewModel(Item));
            }

            var artistRequest = new ArtistSearchRequest()
            {
                ItemsPerPage = itemsPerPage,
                Page = page,
                Name = queryString
            };
            var artistsList = await _artistService.Get<List<Model.Artist>>(artistRequest);
            ArtistsList.Clear();
            foreach (var Item in artistsList)
            {
                ArtistsList.Add(new ArtistViewModel(Item));
            }

            var playlistRequest = new PlaylistSearchRequest()
            {
                ItemsPerPage = itemsPerPage,
                Page = page,
                Name = queryString
            };
            var playlistsList = await _playlistService.Get<List<Model.Playlist>>(playlistRequest);
            PlaylistsList.Clear();
            foreach (var Item in playlistsList)
            {
                PlaylistsList.Add(Item);
            }
        }

        
          
    }
}
