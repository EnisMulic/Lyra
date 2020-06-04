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
    public partial class YourMusicAlbumsPage : ContentPage
    {
        private YourMusicAlbumsViewModel model = null;
        private readonly APIService _service = new APIService("Album");
        private readonly APIService _loggingService = new APIService("User");

        public YourMusicAlbumsPage()
        {
            InitializeComponent();
            BindingContext = model = new YourMusicAlbumsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
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
    }
}