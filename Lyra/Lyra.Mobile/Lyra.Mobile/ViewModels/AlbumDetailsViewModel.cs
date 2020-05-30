using Lyra.Mobile.Helpers;
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
    public class AlbumDetailsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Album");

        private Album album;
        public Album Album
        {
            get { return album; }
            set { SetProperty(ref album, value); }
        }

        public ObservableCollection<Model.Track> TracksList { get; set; } = new ObservableCollection<Model.Track>();
        public ICommand PerformSearch { get; set; }

        public AlbumDetailsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }

        public AlbumDetailsViewModel(Album album)
        {
            Album = album;
            PerformSearch = new Command(async (object query) => await Search(query));
        }

        private async Task Search(object query)
        {
            var request = new TrackSearchRequest()
            {
                Name = query as string
            };

            await Init(request);
        }

        public async Task Init(TrackSearchRequest request = null)
        {
            TracksList.Clear();
            try
            {
                var tracks = await _service.GetTracks<List<Track>>(Album.ID, request);
                foreach (var track in tracks)
                {
                    TracksList.Add(track);
                }
            }
            catch
            {

            }
        }
    }
}
