using Lyra.Mobile.Services;
using Lyra.Mobile.ViewModels;
using Lyra.Model;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistDetailsPage : ContentPage
    {
        private readonly APIService _service = new APIService("Playlist");
        private PlaylistDetailsViewModel model = null;
        public PlaylistDetailsPage(Playlist playlist)
        {
            InitializeComponent();
            BindingContext = model = new PlaylistDetailsViewModel(playlist);
        }

        private async void Track_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var track = (e.SelectedItem as Track);
            var queue = await _service.GetTracks<List<Track>>(model.Playlist.ID, null);
            Image coverImage = new Image()
            {
                Source = ImageSource.FromStream(() => new MemoryStream(model.Playlist.Image))
            };
            await Navigation.PushAsync(new MusicPlayerPage(track, queue, coverImage));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void RemoveTrackFromPlaylist_Clicked(object sender, EventArgs e)
        {
            var button = sender as ImageButton;
            var trackVM = button.BindingContext as TrackViewModel;

            var request = new PlaylistUpsertRequest()
            {
                Name = model.Playlist.Name,
                Image = model.Playlist.Image,
                UserID = model.Playlist.UserID,
                CreatedAt = model.Playlist.CreatedAt,
                TracksToDelete = new List<int>() { trackVM.Track.ID }
            };

            await _service.Update<Playlist>(model.Playlist.ID, request);
            model.TracksList.Remove(trackVM);
        }
    }
}