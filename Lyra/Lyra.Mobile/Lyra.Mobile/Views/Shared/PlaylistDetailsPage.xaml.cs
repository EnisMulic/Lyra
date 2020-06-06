using Lyra.Mobile.Services;
using Lyra.Mobile.ViewModels;
using Lyra.Model;
using System;
using System.Collections.Generic;
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
            await Navigation.PushAsync(new MusicPlayerPage(track, queue));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}