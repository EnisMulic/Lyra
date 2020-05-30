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
    public partial class ActivityPlaylistsPage : ContentPage
    {
        private ActivityPlaylistsViewModel model = null;
        private readonly APIService _service = new APIService("Playlist");

        public ActivityPlaylistsPage()
        {
            InitializeComponent();
            BindingContext = model = new ActivityPlaylistsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Playlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPlaylist = (e.SelectedItem as UserActivityPlaylist);
            await Navigation.PushAsync(new PlaylistDetailsPage(selectedPlaylist.Playlist));
        }
    }
}