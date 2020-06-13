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
    public class PlaylistDetailsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Playlist");

        private Playlist playlist;
        public Playlist Playlist
        {
            get { return playlist; }
            set { SetProperty(ref playlist, value); }
        }

        private byte[] image;
        public byte[] Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        public ObservableCollection<TrackViewModel> TracksList { get; set; } = new ObservableCollection<TrackViewModel>();
        public ICommand PerformSearch { get; set; }
        public ICommand ChangeImage { get; set; }

        public PlaylistDetailsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
            ChangeImage = new Command(async () => await OnTapped());
        }

        public PlaylistDetailsViewModel(Playlist playlist)
        {
            Playlist = playlist;
            Image = playlist.Image;
            PerformSearch = new Command(async (object query) => await Search(query));
            ChangeImage = new Command(async () => await OnTapped());
        }

        private async Task Search(object query)
        {
            var request = new TrackSearchRequest()
            {
                Name = query as string
            };

            await Init(request);
        }


        private async Task OnTapped()
        {
            Image = await UploadImageHelper.UploadImage(Image);

            var request = new PlaylistUpsertRequest()
            {
                Name = Playlist.Name,
                CreatedAt = Playlist.CreatedAt,
                UserID = Playlist.UserID,
                Image = Image
            };

            await _service.Update<Playlist>(Playlist.ID, request);
        }

        public async Task Init(TrackSearchRequest request = null)
        {
            TracksList.Clear();
            try
            {
                var tracks = await _service.GetTracks<List<Track>>(Playlist.ID, request);
                foreach (var track in tracks)
                {
                    TracksList.Add(new TrackViewModel(track));
                }
            }
            catch
            {
                
            }
        }

        
    }
}
