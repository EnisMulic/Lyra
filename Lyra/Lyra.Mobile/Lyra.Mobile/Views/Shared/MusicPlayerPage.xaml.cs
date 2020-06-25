using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Mobile.ViewModels;
using Lyra.Model;
using Lyra.Model.Requests;
using MediaManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MusicPlayerPage : ContentPage
    {
        private readonly APIService _service = new APIService("Review");
        private MusicPlayerViewModel model = null;
        public MusicPlayerPage(Model.Track track, IEnumerable<Model.Track> tracks, Image coverImage)
        {
            InitializeComponent();
            ObservableCollection<Model.Track> queue = null;
            if(tracks != null)
            {
                queue = new ObservableCollection<Model.Track>(tracks);
            }
            BindingContext = model = new MusicPlayerViewModel(track, queue, coverImage);
        }

        private async void Track_ValueChanged(object sender, Syncfusion.SfRating.XForms.ValueEventArgs e)
        {
            int Score = Convert.ToInt32(e.Value);
            var request = new UserTrackReviewUpsertRequest()
            {
                UserID = SignedInUserHelper.User.ID,
                TrackID = model.SelectedTrack.ID,
                Score = Score
            };


            if(model.TrackReview == null)
            {
                model.TrackReview = await _service.Insert<UserTrackReview>(request);
            }
            else if(model.TrackReview != null && model.Score == 0)
            {
                await _service.Delete<bool>(model.TrackReview.ID);
            }
            else
            {
                await _service.Update<UserTrackReview>(model.TrackReview.ID, request);
            }
        }

        protected override async void OnDisappearing()
        {
            FileHelper.DeleteFile(model.filename);
            await CrossMediaManager.Current.Pause();
        }
    }
}