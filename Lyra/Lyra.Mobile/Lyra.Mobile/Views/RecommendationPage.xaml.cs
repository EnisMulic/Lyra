using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lyra.Mobile.Models;
using Lyra.Mobile.Views;
using Lyra.Mobile.ViewModels;
using Lyra.Model.Requests;
using Lyra.Mobile.Services;
using Lyra.Mobile.Helpers;

namespace Lyra.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class RecommendationPage : ContentPage
    {
        private readonly APIService _service = new APIService("User");
        RecommendationViewModel viewModel;
        public RecommendationPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RecommendationViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Init();
        }

        private async void Track_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var trackVM = (e.SelectedItem as TrackViewModel);
            await Navigation.PushAsync(new MusicPlayerPage(trackVM.Track, null, null));

            var request = new UserActivityTrackInsertRequest()
            {
                TrackID = trackVM.Track.ID,
                InteractedAt = DateTime.Now
            };
            await _service.InsertActivityTrack(SignedInUserHelper.User.ID, request);
        }
    }
}