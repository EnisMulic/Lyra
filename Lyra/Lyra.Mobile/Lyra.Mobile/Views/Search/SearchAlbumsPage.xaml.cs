using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Mobile.ViewModels;
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
    public partial class SearchAlbumsPage : ContentPage
    {
        private SearchAlbumsViewModel model = null;
        private readonly APIService _service = new APIService("Artist");
        private readonly APIService _loggingService = new APIService("User");

        public SearchAlbumsPage()
        {
            InitializeComponent();
            BindingContext = model = new SearchAlbumsViewModel();
        }

        public SearchAlbumsPage(string search)
        {
            InitializeComponent();
            BindingContext = model = new SearchAlbumsViewModel(search);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.PerformSearch.Execute(model.SearchQuery);
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