using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Lyra.Mobile.Models;
using Lyra.Mobile.Views;
using Lyra.Mobile.Services;
using Lyra.Mobile.Helpers;
using Lyra.Model;
using Lyra.Model.Requests;

namespace Lyra.Mobile.ViewModels
{
    public class RecommendationViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("User");
        public ObservableCollection<TrackViewModel> TracksList { get; set; } = new ObservableCollection<TrackViewModel>();

        public RecommendationViewModel()
        {
            Title = "Browse";
        }

        public async Task Init()
        {
            IsBusy = true;

            TracksList.Clear();
            try
            {
                var request = new PageRequest()
                {
                    Page = 1,
                    ItemsPerPage = 20
                };

                var tracks = await _service.Recommend(SignedInUserHelper.User.ID, request);
                foreach (var track in tracks)
                {
                    TracksList.Add(new TrackViewModel(track));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}