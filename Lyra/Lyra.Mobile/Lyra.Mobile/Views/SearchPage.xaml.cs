using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Mobile.ViewModels;
using Lyra.Model;
using Lyra.Model.Requests;
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
    public partial class SearchPage : ContentPage
    {
        private readonly APIService _loggingService = new APIService("User");
        private SearchViewModel model;
        public SearchPage(string search = null)
        {
            InitializeComponent();
            BindingContext = model = new SearchViewModel(search);
        }

        private async void Artist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var artistVM = (e.SelectedItem as ArtistViewModel);
            await Navigation.PushAsync(new ArtistDetailsPage(artistVM.Artist));

            var request = new UserActivityArtistInsertRequest()
            {
                ArtistID = artistVM.Artist.ID,
                InteractedAt = DateTime.Now
            };
            await _loggingService.InsertActivityArtist(SignedInUserHelper.User.ID, request);
        }

        private async void Album_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var albumVM = (e.SelectedItem as AlbumViewModel);
            await Navigation.PushAsync(new AlbumDetailsPage(albumVM.Album));

            var request = new UserActivityAlbumInsertRequest()
            {
                AlbumID = albumVM.Album.ID,
                InteractedAt = DateTime.Now
            };
            await _loggingService.InsertActivityAlbum(SignedInUserHelper.User.ID, request);
        }

        private async void Track_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var trackVM = (e.SelectedItem as TrackViewModel);
            await Navigation.PushAsync(new MusicPlayerPage(trackVM.Track, null));

            var request = new UserActivityTrackInsertRequest()
            {
                TrackID = trackVM.Track.ID,
                InteractedAt = DateTime.Now
            };
            await _loggingService.InsertActivityTrack(SignedInUserHelper.User.ID, request);
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