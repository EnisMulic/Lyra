using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class ActivityTracksViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.UserActivityTrack> TracksList { get; set; } = new ObservableCollection<Model.UserActivityTrack>();
        public ICommand PerformSearch { get; set; }

        public ActivityTracksViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }


        private async Task Search(object query)
        {
            var request = new TrackSearchRequest()
            {
                Name = query as string
            };

            await Init(request);
        }

        public async Task Init(TrackSearchRequest request = null)
        {
            TracksList.Clear();
            try
            {
                var UserID = SignedInUserHelper.User.ID;

                var tracks = await _service.GetActivityTracks(UserID, request);
                foreach (var track in tracks)
                {
                    TracksList.Add(track);
                }
            }
            catch
            {

            }
        }
    }
}
