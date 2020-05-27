using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class YourMusicTracksViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.Track> TracksList { get; set; } = new ObservableCollection<Model.Track>();

        public YourMusicTracksViewModel()
        {
        }

        public async Task Init()
        {
            TracksList.Clear();
            try
            {
                int ID = SignedInUserHelper.User.ID;

                var tracks = await _service.GetFavouriteTracks(ID);
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
