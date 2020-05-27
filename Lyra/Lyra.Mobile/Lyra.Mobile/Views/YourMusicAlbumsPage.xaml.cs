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
    public partial class YourMusicAlbumsPage : ContentPage
    {
        private YourMusicAlbumsViewModel model = null;
        private readonly APIService _service = new APIService("Album");

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
            var selectedAlbum = (e.SelectedItem as Album);
            var tracks = await _service.GetTracks<List<Track>>(selectedAlbum.ID, null);
            await Navigation.PushAsync(new MusicPlayerPage(new List<Track>(tracks)));
        }
    }
}