using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Mobile.ViewModels;
using Lyra.Mobile.ViewModels.Search;
using Lyra.Model.Requests;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views.Search
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchTracksPage : ContentPage
    {
        private readonly APIService _service = new APIService("User");
        private SearchTracksViewModel model = null;
        public SearchTracksPage()
        {
            InitializeComponent();
            BindingContext = model = new SearchTracksViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void Track_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var trackVM = (e.SelectedItem as TrackViewModel);
            await Navigation.PushAsync(new MusicPlayerPage(trackVM.Track, null, null));

            var request = new UserActivityTrackInsertRequest()
            {
                TrackID = trackVM.Track.ID,
                InteractedAt = DateTime.Now
            };
            await _service.InsertActivityTrack(SignedInUserHelper.User.ID, request);
        }
    }
}