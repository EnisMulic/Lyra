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
    public partial class ActivityTracksPage : ContentPage
    {
        private ActivityTracksViewModel model = null;

        public ActivityTracksPage()
        {
            InitializeComponent();
            BindingContext = model = new ActivityTracksViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Track_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var track = (e.SelectedItem as Track);
            await Navigation.PushAsync(new MusicPlayerPage(track, new List<Track> { track }));
        }
    }
}