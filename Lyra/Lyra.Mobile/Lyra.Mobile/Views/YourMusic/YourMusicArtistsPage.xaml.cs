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
    public partial class YourMusicArtistsPage : ContentPage
    {
        private YourMusicArtistsViewModel model = null;
        private readonly APIService _service = new APIService("Artist");
        private readonly APIService _loggingService = new APIService("User");

        public YourMusicArtistsPage()
        {
            InitializeComponent();
            BindingContext = model = new YourMusicArtistsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
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
    }
}