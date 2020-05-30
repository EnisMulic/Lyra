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
    public partial class AlbumDetailsPage : ContentPage
    {
        private AlbumDetailsViewModel model = null;
        public AlbumDetailsPage(Album album)
        {
            InitializeComponent();
            BindingContext = model = new AlbumDetailsViewModel(album);
        }

        private async void Track_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var track = (e.SelectedItem as Track);
            await Navigation.PushAsync(new MusicPlayerPage(new List<Track> { track }));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}