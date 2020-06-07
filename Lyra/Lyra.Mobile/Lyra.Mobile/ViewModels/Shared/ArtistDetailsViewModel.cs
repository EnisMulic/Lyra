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
    public class ArtistDetailsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Artist");
        public ObservableCollection<AlbumViewModel> AlbumsList { get; set; } = new ObservableCollection<AlbumViewModel>();

        private Artist artist;
        public Artist Artist
        {
            get { return artist; }
            set { SetProperty(ref artist, value); }
        }

        public ICommand PerformSearch { get; set; }

        public ArtistDetailsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }

        public ArtistDetailsViewModel(Artist artist)
        {
            Artist = artist;
            PerformSearch = new Command(async (object query) => await Search(query));
        }

        private async Task Search(object query)
        {
            var request = new AlbumSearchRequest()
            {
                Name = query as string
            };

            await Init(request);
        }

        public async Task Init(AlbumSearchRequest request = null)
        {
            AlbumsList.Clear();
            try
            {
                var albums = await _service.GetAlbums<List<Album>>(Artist.ID, request);
                foreach (var album in albums)
                {
                    AlbumsList.Add(new AlbumViewModel(album));
                }
            }
            catch
            {

            }
        }
    }
}
