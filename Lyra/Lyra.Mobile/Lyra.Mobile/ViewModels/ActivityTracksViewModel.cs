using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lyra.Mobile.ViewModels
{
    public class ActivityTracksViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.UserActivityTrack> TracksList { get; set; } = new ObservableCollection<Model.UserActivityTrack>();
        public ICommand NewPlaylistCommand { get; set; }

        public async Task Init()
        {
            TracksList.Clear();
            try
            {
                var UserID = SignedInUserHelper.User.ID;

                var tracks = await _service.GetActivityTracks(UserID);
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
