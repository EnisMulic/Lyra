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
    public partial class ActivityArtistsPage : ContentPage
    {
        private ActivityArtistsViewModel model = null;
        private readonly APIService _service = new APIService("Artist");

        public ActivityArtistsPage()
        {
            InitializeComponent();
            BindingContext = model = new ActivityArtistsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Artist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedArtist = (e.SelectedItem as UserActivityArtist);
            await Navigation.PushAsync(new ArtistDetailsPage(selectedArtist.Artist));
        }
    }
}