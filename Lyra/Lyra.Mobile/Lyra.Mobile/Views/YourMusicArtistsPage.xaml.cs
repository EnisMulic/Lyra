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
    public partial class YourMusicArtistsPage : ContentPage
    {
        private YourMusicArtistsViewModel model = null;
        private readonly APIService _service = new APIService("Artist");

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
            var selectedArtist = (e.SelectedItem as Artist);
            await Navigation.PushAsync(new ArtistDetailsPage(selectedArtist));
        }
    }
}