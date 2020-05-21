using Lyra.Mobile.ViewModels;
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
    public partial class YourMusicPlaylistsPage : ContentPage
    {
        private YourMusicPlaylistsViewModel model = null;
        public YourMusicPlaylistsPage()
        {
            InitializeComponent();
            BindingContext = model = new YourMusicPlaylistsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        async void OnTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NewPlaylistPage());
        }

    }
}