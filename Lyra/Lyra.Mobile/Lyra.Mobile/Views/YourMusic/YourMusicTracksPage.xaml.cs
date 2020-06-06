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
    public partial class YourMusicTracksPage : ContentPage
    {
        private readonly APIService _service = new APIService("User");
        private YourMusicTracksViewModel model = null;
        public YourMusicTracksPage()
        {
            InitializeComponent();
            BindingContext = model = new YourMusicTracksViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
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
            await _service.InsertActivityTrack(SignedInUserHelper.User.ID, request);
        }
    }
}