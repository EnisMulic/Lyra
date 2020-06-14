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
    public partial class ArtistDetailsPage : ContentPage
    {
        private ArtistDetailsViewModel model = null;

        public ArtistDetailsPage(Artist artist)
        {
            InitializeComponent();
            BindingContext = model = new ArtistDetailsViewModel(artist);
        }

        private async void Album_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var albumVM = (e.SelectedItem as AlbumViewModel);
            await Navigation.PushAsync(new AlbumDetailsPage(albumVM.Album));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}