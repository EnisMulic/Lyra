using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Mobile.ViewModels.Search;
using Lyra.Model;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views.Search
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPlaylistsPage : ContentPage
    {

        private SearchPlaylistsViewModel model = null;
        private readonly APIService _service = new APIService("Playlist");
        private readonly APIService _loggingService = new APIService("User");
        public SearchPlaylistsPage()
        {
            InitializeComponent();
            BindingContext = model = new SearchPlaylistsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.PerformSearch.Execute(model.SearchQuery);
        }

        async void OnTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NewPlaylistPage());
        }

        private async void Playlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPlaylist = (e.SelectedItem as Playlist);
            await Navigation.PushAsync(new PlaylistDetailsPage(selectedPlaylist));

            var request = new UserActivityPlaylistInsertRequest()
            {
                PlaylistID = selectedPlaylist.ID,
                InteractedAt = DateTime.Now
            };
            await _loggingService.InsertActivityPlaylist(SignedInUserHelper.User.ID, request);
        }
    }
}